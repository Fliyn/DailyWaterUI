using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyWaterUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            MySqlDataAdapter sqql = new MySqlDataAdapter("SELECT Count(*) From kullanıcı Where İsim='" + TextBox1.Text + "' and Şifre='" + TextBox3.Text + "'  ", sql);
            DataTable tab = new DataTable();
            sqql.Fill(tab);
            if (tab.Rows[0][0].ToString() == "1")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else {
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
            sql.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)//rakam ve harf kontrolü
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
        }
    }
}
