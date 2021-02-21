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
    public partial class font_form : Form
    {
        private TextBox textBox_f;

        private string font = "Microsoft Sans Serif";
        private int size = 8;

        public font_form(ref TextBox textBox1)
        {
            InitializeComponent();
            textBox_f = textBox1;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();  

            textBox.Font = new System.Drawing.Font(font, size);
            textBox_f.Font = textBox.Font;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void font_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = font_box.Text;
            lable_text.Font = new System.Drawing.Font(font, size);
        }
        private void size_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Int32.Parse(size_box.Text);
            lable_text.Font = new System.Drawing.Font(font, size);
        }

        private void font_form_Load(object sender, EventArgs e)
        {
            font_box.SelectedIndex = 0;
            size_box.SelectedIndex = 0;
        }     
    }
}
