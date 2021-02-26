
namespace SimpleNotepad
{
    partial class replace_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(replace_form));
            this.in_textBox = new System.Windows.Forms.TextBox();
            this.out_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replace_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // in_textBox
            // 
            this.in_textBox.Location = new System.Drawing.Point(59, 23);
            this.in_textBox.Name = "in_textBox";
            this.in_textBox.Size = new System.Drawing.Size(160, 20);
            this.in_textBox.TabIndex = 0;
            // 
            // out_textBox
            // 
            this.out_textBox.Location = new System.Drawing.Point(59, 53);
            this.out_textBox.Name = "out_textBox";
            this.out_textBox.Size = new System.Drawing.Size(160, 20);
            this.out_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Что:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Чем:";
            // 
            // replace_button
            // 
            this.replace_button.Location = new System.Drawing.Point(27, 102);
            this.replace_button.Name = "replace_button";
            this.replace_button.Size = new System.Drawing.Size(72, 23);
            this.replace_button.TabIndex = 4;
            this.replace_button.Text = "Заменить";
            this.replace_button.UseVisualStyleBackColor = true;
            this.replace_button.Click += new System.EventHandler(this.replace_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(147, 102);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(72, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // replace_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 135);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.replace_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out_textBox);
            this.Controls.Add(this.in_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "replace_form";
            this.Text = "Заменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in_textBox;
        private System.Windows.Forms.TextBox out_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replace_button;
        private System.Windows.Forms.Button cancel_button;
    }
}