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
    public partial class main_form : Form
    {
        private string path;
        public main_form()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Application.Exit();
                    this.Text = "* - SimpleNotepad";
                }
            }
            else
            {
                Application.Exit();
            }      
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    path = string.Empty;
                    textBox1.Clear();
                }
            }
            else
            {
                path = string.Empty;
                textBox1.Clear();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All Files|*.*", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            path = ofd.FileName;
                            this.Text = ofd.FileName + " - SimpleNotepad";
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

        private async void saveAS(string text)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        this.Text = sf.FileName + " - SimpleNotepad";
                        path = sf.FileName;
                        using (StreamWriter sw = new StreamWriter(sf.FileName))
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

        private async void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(path))
            {
                saveAS(textBox1.Text);
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
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

        private void сохранитьКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveAS(textBox1.Text);
        }

        private void светлыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ForeColor = Color.Black;
        }

        private void темныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font_form ff = new font_form(ref textBox1);
            ff.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Text = "* - SimpleNotepad";
                textBox1.Text = "";
                path = "";
            }        
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var res = MessageBox.Show("У вас могу быть несохраненные данные!\nПродолжить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

                try
                {
                    using (StreamReader sr = new StreamReader(file[0]))
                    {
                        path = file[0];
                        this.Text = file[0] + " - SimpleNotepad";
                        Task<string> prev_text = sr.ReadToEndAsync();
                        textBox1.Text = prev_text.Result;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Что-то пошло не так!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
