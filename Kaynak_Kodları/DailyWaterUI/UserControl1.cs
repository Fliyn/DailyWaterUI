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
using System.Threading;

namespace DailyWaterUI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {

            InitializeComponent();
        }
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                string sorgu = "select BuGüniçilenSu from hesaplamaverileri where Tarih = (select max(Tarih) from hesaplamaverileri)";
                MySqlCommand val = new MySqlCommand(sorgu, sql);
                int a = Convert.ToInt32(val.ExecuteScalar());
                PictureBox7.Width = a / 6;
                PictureBox14.Width = a / 6;
                guna2PictureBox2.Width = a / 6;
                guna2PictureBox3.Width = a / 6;
                sql.Close();
            }
            catch (Exception)
            {
            }

            double k;
            double u = 0.03;
            double t;
            t = Form4.kilo;
            k = (u * t);
            if (k >= 3)
            {
                pictureBox2.Visible = true;
                pictureBox6.Visible = true;
                label2.Visible = true;
                label6.Visible = true;
            }
            else if (k > 2)
            {
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                label2.Visible = true;
                label5.Visible = true;
            }
            else if (k > 1)
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else if (k > 0)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
            }

            sql.Open();
            DataTable dt = new DataTable();
            string d = ("SELECT * FROM market WHERE idMarket=1 and kullanılabilirlik=1");
            MySqlCommand cmd = new MySqlCommand(d, sql);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("1", 1);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                PictureBox1.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt1 = new DataTable();
            string d1 = ("SELECT * FROM market WHERE idMarket=2 and kullanılabilirlik=1");
            MySqlCommand cmd1 = new MySqlCommand(d1, sql);
            MySqlDataAdapter ad1 = new MySqlDataAdapter(cmd1);
            cmd1.Parameters.AddWithValue("1", 1);
            ad1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                PictureBox8.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt2 = new DataTable();
            string d2 = ("SELECT * FROM market WHERE idMarket=3 and kullanılabilirlik=1");
            MySqlCommand cmd2 = new MySqlCommand(d2, sql);
            MySqlDataAdapter ad2 = new MySqlDataAdapter(cmd2);
            cmd2.Parameters.AddWithValue("1", 1);
            ad2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                PictureBox9.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt3 = new DataTable();
            string d3 = ("SELECT * FROM market WHERE idMarket=4 and kullanılabilirlik=1");
            MySqlCommand cmd3 = new MySqlCommand(d3, sql);
            MySqlDataAdapter ad3 = new MySqlDataAdapter(cmd3);
            cmd3.Parameters.AddWithValue("1", 1);
            ad3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                PictureBox10.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt4 = new DataTable();
            string d4 = ("SELECT * FROM market WHERE idMarket=5 and kullanılabilirlik=1");
            MySqlCommand cmd4 = new MySqlCommand(d4, sql);
            MySqlDataAdapter ad4 = new MySqlDataAdapter(cmd4);
            cmd4.Parameters.AddWithValue("1", 1);
            ad4.Fill(dt4);
            if (dt4.Rows.Count > 0)
            {
                PictureBox7.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt5 = new DataTable();
            string d5 = ("SELECT * FROM market WHERE idMarket=6 and kullanılabilirlik=1");
            MySqlCommand cmd5 = new MySqlCommand(d5, sql);
            MySqlDataAdapter ad5 = new MySqlDataAdapter(cmd5);
            cmd5.Parameters.AddWithValue("1", 1);
            ad5.Fill(dt5);
            if (dt5.Rows.Count > 0)
            {
                PictureBox14.Visible = true;
            }
            sql.Close();

            sql.Open();
            DataTable dt6 = new DataTable();
            string d6 = ("SELECT * FROM market WHERE idMarket=7 and kullanılabilirlik=1");
            MySqlCommand cmd6 = new MySqlCommand(d6, sql);
            MySqlDataAdapter ad6 = new MySqlDataAdapter(cmd6);
            cmd6.Parameters.AddWithValue("1", 1);
            ad6.Fill(dt6);
            if (dt6.Rows.Count > 0)
            {
                guna2PictureBox2.Visible = true;
            }
            sql.Close();
            sql.Open();
            DataTable dt7 = new DataTable();
            string d7 = ("SELECT * FROM market WHERE idMarket=8 and kullanılabilirlik=1");
            MySqlCommand cmd7 = new MySqlCommand(d7, sql);
            MySqlDataAdapter ad7 = new MySqlDataAdapter(cmd7);
            cmd7.Parameters.AddWithValue("1", 1);
            ad7.Fill(dt7);
            if (dt7.Rows.Count > 0)
            {
                guna2PictureBox3.Visible = true;
            }
            sql.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("d.MM.yyyy 00:00:00");

            sql.Open();
            string sorgu = "select Tarih from hesaplamaverileri where Tarih = (select max(Tarih) from hesaplamaverileri)";
            MySqlCommand val = new MySqlCommand(sorgu, sql);
            string a = Convert.ToString(val.ExecuteScalar());
            sql.Close();
            if (time.Equals(a))
            { }
            else
            {
                var wa = DateTime.Now.ToString("yyyy.MM.dd");
                sql.Open();
                string query = "INSERT INTO hesaplamaverileri (idHesaplama, BuGüniçilenSu, Tarih) VALUES (idHesaplama, 0 , '" + wa + "')";
                MySqlCommand cmd = new MySqlCommand(query, sql);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("yeni gün");
            }

            timer1.Start();
            if (timer1.Enabled)
            {
                PictureBox11.Visible = true;
            }
            try
            {
                ProgressBar1.Value = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception)
            {
            }


            try
            {
                sql.Open();
                int c = (100 + (Convert.ToInt32(this.TextBox1.Text)));
                string x = "UPDATE gdveriler SET KazanılanP=(KazanılanP+'" + c + "')  where idGüncel=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                cmd.CommandText = x;
                cmd.ExecuteNonQuery();
                sql.Close();

                sql.Open();
                string y = "UPDATE hesaplamaverileri SET BuGüniçilenSu=(BuGüniçilenSu+'" + TextBox1.Text + "')  where idHesaplama = (select max(idHesaplama) from hesaplamaverileri)";
                MySqlCommand xmd = new MySqlCommand(y, sql);
                xmd.CommandText = y;
                xmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (Exception)
            {
            }
            double f;
            double g = 0.03;
            double j;
            j = UserControl4.Kilo;
            f = (g * j);
            if (f >= 2.5)
            {
                pictureBox2.Visible = true;
                pictureBox6.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label2.Visible = true;
                label6.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else if (f > 2)
            {
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label2.Visible = true;
                label5.Visible = true;
                label6.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            else if (f >= 1.5)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                pictureBox6.Visible = false;
                label5.Visible = true;
                label4.Visible = true;
                label6.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            else if (f > 0)
            {
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox6.Visible = false;
                label4.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
            }
            try
            {
                int w = Convert.ToInt32(TextBox1.Text);
                int t = PictureBox7.Size.Width;
                PictureBox7.Width = t + w / 6;
                PictureBox14.Width = t + w / 6;
                guna2PictureBox2.Width = t + w / 6;
                guna2PictureBox3.Width = t + w / 6;
            }
            catch (Exception)
            {
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 9000;
            PictureBox11.Visible = false;
            timer1.Stop();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
