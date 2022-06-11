using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DailyWaterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");


        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            string x = "insert into kullanıcı(İsim,Şifre,Eposta,Soyisim)values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox2.Text + "')";
            if (!x.Equals(true))
            {
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
            MySqlCommand cmd = new MySqlCommand(x, sql);
            cmd.CommandText = x;
            cmd.ExecuteNonQuery();
            sql.Close();
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextBox4_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (TextBox4.Text.Length > 0)
            {
                if (!email.IsMatch(TextBox4.Text))
                {
                    msgbox msgbox = new msgbox();
                    msgbox.Show();
                    e.Cancel = true;
                }
            }
        }
    }
}
