using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    //<-- Форма замены текста -->
    public partial class replace_form : Form
    {
        private RichTextBox textBox_f; // Переменная текстБокса, в которой будем менять

        public replace_form(ref RichTextBox textBox) // Передаем основной текстБокс ссылкой
        {
            InitializeComponent();
            textBox_f = textBox;
        }

        //<-- Нажатие на кнопку Отмена -->
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //<-- Нажатие на кнопку ОК -->
        private void replace_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(in_textBox.Text) || String.IsNullOrWhiteSpace(out_textBox.Text)) // Если пользователь не ввел данные для замены
            {
                MessageBox.Show(this, "Вы должны заполнить всен поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Выводим предупреждение
            }
            else
            {
                textBox_f.Text = new Regex($"{in_textBox.Text}").Replace(textBox_f.Text, out_textBox.Text); // Ищем и заменяем
                this.Close(); // Закрываем окно
            }
        }
    }
}
