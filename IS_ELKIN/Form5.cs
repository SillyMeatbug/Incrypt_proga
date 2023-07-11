using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IS_ELKIN
{
    public partial class Form5 : Form
    {
        byte[] abc;
        byte[,] table;
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Check input values
            if (!File.Exists(fname.Text))
            {
                MessageBox.Show("Файл не найден");
                return;
            }

            // Get file content and key for encrypt/decrypt
            if (Pass.Text.Length == 0)
            {
                MessageBox.Show("Введите ключ");
                return;
            }

            // Encrypt
            try
            {
                byte[] fileContent = File.ReadAllBytes(fname.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(Pass.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                // Encrypt
                byte[] result = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;
                    for (int j = 0; j < 256; j++)
                        if (abc[j] == key)
                        {
                            keyIndex = j;
                            break;
                        }
                    for (int j = 0; j < 256; j++)
                        if (table[keyIndex, j] == value)
                        {
                            valueIndex = j;
                            break;
                        }
                    result[i] = abc[valueIndex];
                }
                // Save result to new file with the same extension
                String fileExt = Path.GetExtension(fname.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("Данный файл используется.");
                return;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
    }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileChouse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                fname.Text = od.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(); frm3.Show();
            this.Close();
        }
    }
}
