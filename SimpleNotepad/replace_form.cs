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
    public partial class replace_form : Form
    {
        private TextBox textBox_f;

        public replace_form(ref TextBox textBox)
        {
            InitializeComponent();
            textBox_f = textBox;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replace_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(in_textBox.Text) || String.IsNullOrWhiteSpace(out_textBox.Text))
            {
                MessageBox.Show(this, "Вы должны заполнить всен поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox_f.Text = new Regex($"{in_textBox.Text}").Replace(textBox_f.Text, out_textBox.Text);
                this.Close();
            }
        }
    }
}
