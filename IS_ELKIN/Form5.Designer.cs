namespace IS_ELKIN
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.FileChouse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ключ";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(179, 103);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(227, 22);
            this.Pass.TabIndex = 8;
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // fname
            // 
            this.fname.Enabled = false;
            this.fname.Location = new System.Drawing.Point(34, 65);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(309, 22);
            this.fname.TabIndex = 7;
            this.fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // FileChouse
            // 
            this.FileChouse.Location = new System.Drawing.Point(349, 64);
            this.FileChouse.Name = "FileChouse";
            this.FileChouse.Size = new System.Drawing.Size(121, 23);
            this.FileChouse.TabIndex = 6;
            this.FileChouse.Text = "Выбрать файл";
            this.FileChouse.UseVisualStyleBackColor = true;
            this.FileChouse.Click += new System.EventHandler(this.FileChouse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "В меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.FileChouse);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button FileChouse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}