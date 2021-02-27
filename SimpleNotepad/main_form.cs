using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    //<-- Основная форма -->
    public partial class main_form : Form
    {
        private string path; // Переменная текущего пути к файлу, над которым работаем

        public main_form()
        {
            InitializeComponent();
        }
        
        //<-- Вспомогательная функция для выхода -->
        private bool ExitCheck()
        {
            if (textBox1.TextLength != 0)
            {
                var res = MessageBox.Show("У вас могу быть несохраненные данные!\nВыйти?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        //<-- Выход из программы -->
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close(); // Вызываем закрытие формы, его перехватит след функция
        }

        //<-- Перехватываем закрытие формы -->
        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        { 
            e.Cancel = !ExitCheck(); // Закрываем с разрешения пользователя
        }

        //<-- Функция создания нового файла -->
        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0) // Если что-то уже написано
            {
                var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    path = string.Empty; // Очищаем текущий путь
                    textBox1.Clear();
                }
            }
            else
            {
                path = string.Empty; // Очищаем текущий путь
                textBox1.Clear();
            }
        }

        //<-- Функция открытия файла -->
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files|*.*", ValidateNames = true, Multiselect = false }) // Открываем диалог с выбором файла
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName)) // Читаем текст из файла
                        {
                            path = ofd.FileName; // Записываем путь к файлу
                            this.Text = ofd.FileName + " - SimpleNotepad"; // Меняем заголовок формы
                            Task<string> prev_text = sr.ReadToEndAsync();
                            textBox1.Text = prev_text.Result;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //<-- Функция сохранить как -->
        private async void saveAS(string text)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true }) // Открываем диалог с сохранением файла
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        this.Text = sf.FileName + " - SimpleNotepad"; // Записываем в заголовок новый путь
                        path = sf.FileName; // Записываем путь в переменную
                        using (StreamWriter sw = new StreamWriter(sf.FileName)) // Записываем весь текст в файл
                        {
                            await sw.WriteAsync(text);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //<-- Функция сохранения в меню -->
        private async void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(path)) // Если нет текущего пути, вызываем функцию сохранить как
            {
                saveAS(textBox1.Text);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path)) // Записываем весь текст в файл
                    {
                        await sw.WriteAsync(textBox1.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //<-- Функция сохранить как в меню -->
        private void сохранитьКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveAS(textBox1.Text);
        }

        //<-- Поменять тему на светлую -->
        private void светлыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
        }

        //<-- Поменять тему на темную -->
        private void темныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
        }

        //<-- Поменять шрифт -->
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font_form ff = new font_form(ref textBox1); // Вызываем новое окно смены шрифта
            ff.Show();
        }

        //<-- Закрыть текущий файл -->
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes) 
            {
                // Очищаем путь, текст и заголовок
                this.Text = "* - SimpleNotepad";
                textBox1.Text = ""; 
                path = "";
            }        
        }

        //<-- Функция для поддержки Drag And Drop -->
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop); // Выбираем ВСЕ пути к кинутым файлам

                try
                {
                    using (StreamReader sr = new StreamReader(file[0])) // Читаем только первый кинутый файл
                    {
                        path = file[0]; // Записываем путь к файлу
                        this.Text = file[0] + " - SimpleNotepad";
                        Task<string> prev_text = sr.ReadToEndAsync(); // Читаем файл и записываем в textBox
                        textBox1.Text = prev_text.Result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //<-- Когда файл входит в зону текстбокса -->
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        //<-- Функция замены текста -->
        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace_form rf = new replace_form(ref textBox1); // Вызываем новое окно замены текста
            rf.Show();
        }
    }
}
