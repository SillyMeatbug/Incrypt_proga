using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_ELKIN
{
    public partial class Form2 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Пользователям запрещено изменять код исходника информационной системы." +
              " В целях сохранения конфиденциальности информации, пользователям также запрещено просматривать, копировать и распространять информацию из исходной базы данных программы.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool count1 = true; 
            foreach(DataRow currentRow in this.пользователиTableAdapter.GetData().Rows)
            {
                if (currentRow.ItemArray.Length == 0)
                {
                    break;
                }
                if (currentRow.ItemArray[1].ToString() == UsrLog.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует в базе данных");
                    count1 = false;
                    break;
                }
            }
            if (count1)
            {
                this.пользователиTableAdapter.Insert(UsrLog.Text, UsrPass.Text, DateTime.Today);
                MessageBox.Show("Пользователь зарегистрирован в базе данных");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.usersDataSet.Пользователи);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); frm1.Show();
            this.Close();
        }

    }
}
