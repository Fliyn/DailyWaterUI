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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static double kilo;
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                string d = "Kadın";
                if (RadioButton1.Checked) { d = "Erkek"; }
                string x = "UPDATE kullanıcı SET Yaş= '" + NumericUpDown1.Value + "' ,Kilo = '" + TextBox2.Text + "' ,Boy= '" + TextBox3.Text + "' ,Cinsiyet ='" + d + "' where idKullanıcı=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
                kilo = Convert.ToInt32(TextBox2.Text);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            catch (Exception)
            {
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
            
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)// only rakam alıyor. yoksa hata veriyor.
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
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
