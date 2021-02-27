using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    //<-- Форма смены шрифта -->
    public partial class font_form : Form
    {
        private TextBox textBox_f; // Переменная текстБокса, которой мы будем задавать шрифт

        // Шрифт и размеры
        private string font;
        private float size;

        public font_form(ref TextBox textBox1) // Передаем основной текстБокс ссылкой
        {
            InitializeComponent();
            textBox_f = textBox1;

            // Записываем текущие шрифт и размер
            size = textBox_f.Font.Size;
            font = textBox_f.Font.FontFamily.ToString();
        }

        //<-- Нажатие на кнопку ОК -->
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_f.Font = new System.Drawing.Font(font, size); // Передаем новый шрифт
            this.Close(); // Закрываем окно
        }

        //<-- Нажатие на кнопку Отмена -->
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем окно не изменяя шрифт
        }

        //<-- Если выбран другой шрифт -->
        private void font_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = font_box.Text; // Записываем новый шрифт в переменную
            lable_text.Font = new System.Drawing.Font(font, size); // Передаем новый шрифт в тестовое поле
        }

        //<-- Если выбран другой размер -->
        private void size_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Int32.Parse(size_box.Text); // Записываем новый размер в переменную
            lable_text.Font = new System.Drawing.Font(font, size); // Передаем новый размер в тестовое поле
        }

        //<-- При загрузке окна -->
        private void font_form_Load(object sender, EventArgs e)
        {
            // Заполняем макет текущим шрифтом
            lable_text.Font = new System.Drawing.Font(font, size);
        }     
    }
}
