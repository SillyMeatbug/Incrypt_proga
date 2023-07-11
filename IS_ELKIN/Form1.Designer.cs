
namespace IS_ELKIN
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsrLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsrPass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new IS_ELKIN.UsersDataSet();
            this.пользователиTableAdapter = new IS_ELKIN.UsersDataSetTableAdapters.ПользователиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Авторизация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ещё не зарегестрированны?";
            // 
            // UsrLog
            // 
            this.UsrLog.Location = new System.Drawing.Point(119, 39);
            this.UsrLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsrLog.Name = "UsrLog";
            this.UsrLog.Size = new System.Drawing.Size(132, 22);
            this.UsrLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UsrPass
            // 
            this.UsrPass.Location = new System.Drawing.Point(119, 97);
            this.UsrPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsrPass.Name = "UsrPass";
            this.UsrPass.PasswordChar = '*';
            this.UsrPass.Size = new System.Drawing.Size(132, 22);
            this.UsrPass.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.датарегистрацииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.пользователиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(653, 185);
            this.dataGridView1.TabIndex = 8;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.Width = 125;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.Width = 125;
            // 
            // датарегистрацииDataGridViewTextBoxColumn
            // 
            this.датарегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_регистрации";
            this.датарегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата_регистрации";
            this.датарегистрацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датарегистрацииDataGridViewTextBoxColumn.Name = "датарегистрацииDataGridViewTextBoxColumn";
            this.датарегистрацииDataGridViewTextBoxColumn.Width = 125;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.usersDataSetBindingSource;
            // 
            // usersDataSetBindingSource
            // 
            this.usersDataSetBindingSource.DataSource = this.usersDataSet;
            this.usersDataSetBindingSource.Position = 0;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 404);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UsrPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsrLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Добро пожаловать!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsrLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsrPass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usersDataSetBindingSource;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private UsersDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарегистрацииDataGridViewTextBoxColumn;
    }
}

