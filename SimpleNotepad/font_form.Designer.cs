
namespace SimpleNotepad
{
    partial class font_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(font_form));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.font_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable_text = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lable_text);
            this.groupBox1.Controls.Add(this.size_box);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.font_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // size_box
            // 
            this.size_box.FormattingEnabled = true;
            this.size_box.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "22",
            "24",
            "28",
            "32",
            "36",
            "38",
            "44",
            "52",
            "64"});
            this.size_box.Location = new System.Drawing.Point(208, 36);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(148, 21);
            this.size_box.TabIndex = 5;
            this.size_box.SelectedIndexChanged += new System.EventHandler(this.size_box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер:";
            // 
            // font_box
            // 
            this.font_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.font_box.FormattingEnabled = true;
            this.font_box.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Comic Sans MS",
            "Brittanic",
            "Calibri"});
            this.font_box.Location = new System.Drawing.Point(32, 36);
            this.font_box.Name = "font_box";
            this.font_box.Size = new System.Drawing.Size(135, 21);
            this.font_box.TabIndex = 1;
            this.font_box.SelectedIndexChanged += new System.EventHandler(this.font_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шрифт:";
            // 
            // lable_text
            // 
            this.lable_text.Location = new System.Drawing.Point(32, 80);
            this.lable_text.Name = "lable_text";
            this.lable_text.Size = new System.Drawing.Size(210, 77);
            this.lable_text.TabIndex = 6;
            this.lable_text.Text = "AaBbCc";
            // 
            // font_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 181);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "font_form";
            this.Text = "Изменение шрифта";
            this.Load += new System.EventHandler(this.font_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox size_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox font_box;
        private System.Windows.Forms.Label lable_text;
    }
}