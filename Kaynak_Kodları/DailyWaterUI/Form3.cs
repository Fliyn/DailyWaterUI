using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DailyWaterUI
{
    public partial class Form3 : Form
    {
        //public static int puan = 2000;

        public Form3()
        {
            InitializeComponent();
        }

        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Start();
            Label1.Text = DateTime.Now.ToString("hh:mm:ss");
            Label2.Text = DateTime.Now.ToString("dd.MM.yyyy");
            Label3.Text = DateTime.Now.ToString("dddd");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sql.Open();
            string x = "select * from gdveriler where idGüncel=1";
            MySqlCommand cmd = new MySqlCommand(x, sql);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label5.Text = dr["KazanılanP"].ToString();

            }
            sql.Close();
            timer1.Start();
        }

        private void Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (Button1.Checked)
            {
                userControl1.BringToFront();
            }
        }

        private void Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (Button2.Checked)
            {
                userControl2.BringToFront();
            }
        }

        private void Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (Button3.Checked)
            {
                userControl3.BringToFront();
            }
        }

        private void Button4_CheckedChanged(object sender, EventArgs e)
        {
            if (Button4.Checked)
            {
                userControl4.BringToFront();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sql.Open();
            string x = "select * from gdveriler where idGüncel=1";
            MySqlCommand cmd = new MySqlCommand(x, sql);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label5.Text = dr["KazanılanP"].ToString();
            }
            sql.Close();

            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
