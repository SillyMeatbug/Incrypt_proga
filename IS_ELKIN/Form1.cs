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
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usr = UsrLog.Text;
            string psw = UsrPass.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=|DataDirectory|\..\DataBase_IS.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM Пользователи where Логин='" + UsrLog.Text + "' AND Пароль='" + UsrPass.Text + "'";
            cmd.CommandText = str;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Form3 frm3 = new Form3(); frm3.Show();
                frm3.label1.Text = this.UsrLog.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.usersDataSet.Пользователи);

        }
    }
}
