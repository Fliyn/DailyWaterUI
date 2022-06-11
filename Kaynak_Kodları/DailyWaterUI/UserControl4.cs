using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DailyWaterUI
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        public static double Kilo;
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            string d = "Kadın";
            if (RadioButton1.Checked) { d = "Erkek"; }
            string x = "UPDATE kullanıcı SET Yaş= '" + TextBox3.Text + "' ,Kilo = '" + TextBox2.Text + "' ,Boy= '" + TextBox1.Text + "' ,Cinsiyet ='" + d + "' where idKullanıcı=1";
            MessageBox.Show("Veri Güncelleme Başarılı.");
            MySqlCommand cmd = new MySqlCommand(x, sql);
            cmd.ExecuteNonQuery();


            string t = "select * from kullanıcı where idKullanıcı=1";
            MessageBox.Show("Yükleniyor...");
            MySqlCommand cod = new MySqlCommand(t, sql);
            MySqlDataReader xxx = cod.ExecuteReader();
            if (xxx.Read())
            {
                Label7.Text = xxx["İsim"].ToString();
                Label8.Text = xxx["Yaş"].ToString();
                Label9.Text = xxx["Kilo"].ToString();
                Label10.Text = xxx["Boy"].ToString();
                Label11.Text = xxx["Cinsiyet"].ToString();

            }
            sql.Close();
            //kilo = Convert.ToInt32(TextBox2.Text);
            Kilo = Convert.ToInt32(TextBox2.Text);

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            sql.Open();
            string k = "select * from kullanıcı where idKullanıcı=1";
            MySqlCommand cad = new MySqlCommand(k, sql);
            MySqlDataReader ddd = cad.ExecuteReader();
            if (ddd.Read())
            {
                Label7.Text = ddd["İsim"].ToString();
                Label8.Text = ddd["Yaş"].ToString();
                Label9.Text = ddd["Kilo"].ToString();
                Label10.Text = ddd["Boy"].ToString();
                Label11.Text = ddd["Cinsiyet"].ToString();
            }
            sql.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
