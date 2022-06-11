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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");

        //int x = Convert.ToInt32(Form3.puan);

        private void UserControl7_Load(object sender, EventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            string puan = "select KazanılanP from gdveriler where idGüncel = 1";
            MySqlCommand p = new MySqlCommand(puan, sql);
            int spuan = Convert.ToInt32(p.ExecuteScalar());

            if (spuan >= 2000)
            {
                string x = "UPDATE market SET kullanılabilirlik=1  where idMarket=5";
                string y = "UPDATE gdveriler SET KazanılanP=(KazanılanP-2000) where idGüncel=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                MySqlCommand havi = new MySqlCommand(y, sql);
                cmd.ExecuteNonQuery();
                havi.ExecuteNonQuery();
                sql.Close();
            }
            else
            {
                MessageBox.Show("Puan Yeterli Değil.");
                sql.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            string puan = "select KazanılanP from gdveriler where idGüncel = 1";
            MySqlCommand p = new MySqlCommand(puan, sql);
            int spuan = Convert.ToInt32(p.ExecuteScalar());

            if (spuan >= 2000)
            {
                string x = "UPDATE market SET kullanılabilirlik=1  where idMarket=6";
                string y = "UPDATE gdveriler SET KazanılanP=(KazanılanP-2000) where idGüncel=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                MySqlCommand havi = new MySqlCommand(y, sql);
                cmd.ExecuteNonQuery();
                havi.ExecuteNonQuery();
                sql.Close();
            }
            else
            {
                MessageBox.Show("Puan Yeterli Değil.");
                sql.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            sql.Open();
            string puan = "select KazanılanP from gdveriler where idGüncel = 1";
            MySqlCommand p = new MySqlCommand(puan, sql);
            int spuan = Convert.ToInt32(p.ExecuteScalar());

            if (spuan >= 2000)
            {
                string x = "UPDATE market SET kullanılabilirlik=1  where idMarket=7";
                string y = "UPDATE gdveriler SET KazanılanP=(KazanılanP-2000) where idGüncel=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                MySqlCommand havi = new MySqlCommand(y, sql);
                cmd.ExecuteNonQuery();
                havi.ExecuteNonQuery();
                sql.Close();
            }
            else
            {
                MessageBox.Show("Puan Yeterli Değil.");
                sql.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            sql.Open();
            string puan = "select KazanılanP from gdveriler where idGüncel = 1";
            MySqlCommand p = new MySqlCommand(puan, sql);
            int spuan = Convert.ToInt32(p.ExecuteScalar());

            if (spuan >= 2000)
            {
                string x = "UPDATE market SET kullanılabilirlik=1  where idMarket=8";
                string y = "UPDATE gdveriler SET KazanılanP=(KazanılanP-2000) where idGüncel=1";
                MySqlCommand cmd = new MySqlCommand(x, sql);
                MySqlCommand havi = new MySqlCommand(y, sql);
                cmd.ExecuteNonQuery();
                havi.ExecuteNonQuery();
                sql.Close();
            }
            else
            {
                MessageBox.Show("Puan Yeterli Değil.");
                sql.Close();
            }
        }
    }
}
