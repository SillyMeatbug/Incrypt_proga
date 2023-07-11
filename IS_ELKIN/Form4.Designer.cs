namespace IS_ELKIN
{
    partial class Form4
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileChouse = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // FileChouse
            // 
            this.FileChouse.Location = new System.Drawing.Point(338, 48);
            this.FileChouse.Name = "FileChouse";
            this.FileChouse.Size = new System.Drawing.Size(121, 23);
            this.FileChouse.TabIndex = 1;
            this.FileChouse.Text = "Выбрать файл";
            this.FileChouse.UseVisualStyleBackColor = true;
            this.FileChouse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fname
            // 
            this.fname.Enabled = false;
            this.fname.Location = new System.Drawing.Point(23, 49);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(309, 22);
            this.fname.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(168, 87);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(227, 22);
            this.Pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "В меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 202);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.FileChouse);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FileChouse;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox Pass;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}