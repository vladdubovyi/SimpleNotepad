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

        public font_form(ref TextBox textBox1)
        {
            InitializeComponent();
            textBox_f = textBox1;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();

            string font = font_box.Text;
            int size_id = size_box.SelectedIndex, size;

            switch(size_id)
            {
                case 1:
                    size = 12;
                    break;
                case 2:
                    size = 14;
                    break;
                case 3:
                    size = 18;
                    break;
                case 4:
                    size = 22;
                    break;
                case 5:
                    size = 24;
                    break;
                case 6:
                    size = 32;
                    break;
                case 7:
                    size = 38;
                    break;
                case 8:
                    size = 52;
                    break;
                default:
                    size = 16;
                    break;
            }

            textBox.Font = new System.Drawing.Font(font, size);
            textBox_f.Font = textBox.Font;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
