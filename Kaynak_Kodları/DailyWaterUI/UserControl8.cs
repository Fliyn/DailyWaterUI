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
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void Button1_Click(object sender, EventArgs e)
        {
            string x = "Select * from hesaplamaverileri";
            MySqlCommand cmd = new MySqlCommand(x, sql);
            MySqlDataReader mySqlDataReader;
            try
            {
                sql.Open();
                mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    this.chart1.Series[0].Points.AddXY(mySqlDataReader.GetMySqlDateTime("Tarih").ToString(), mySqlDataReader.GetInt32("BuGüniçilenSu"));
                }
                sql.Close();
                sql.Open();
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select BuGüniçilenSu, Tarih from hesaplamaverileri", sql);
                mySqlDataAdapter.Fill(dataTable);
                DataGridView1.DataSource = dataTable;
                sql.Close();
                sql.Open();
                string su_toplam2 = "SELECT Sum(BuGüniçilenSu) FROM hesaplamaverileri";
                string su_toplam3 = "SELECT COUNT(idHesaplama) FROM hesaplamaverileri";
                MySqlCommand cmd2 = new MySqlCommand(su_toplam2, sql);
                MySqlCommand cmd3 = new MySqlCommand(su_toplam3, sql);
                int v = Convert.ToInt32(cmd2.ExecuteScalar());
                int y = Convert.ToInt32(cmd3.ExecuteScalar());
                int c;
                c = v / y;
                MessageBox.Show("Ortalama: " + c.ToString());
                sql.Close();
                sql.Open();
                string su_topla4 = "UPDATE istatikselveriler SET 1günlükORT='" + c + "' WHERE idGeçmiş=1";
                MySqlCommand cmd11 = new MySqlCommand(su_topla4, sql);
                cmd11.ExecuteNonQuery();
                ProgressBar1.Value = Convert.ToInt32(c);
            }
            catch (Exception)
            {
                msgbox msgbox = new msgbox();
                msgbox.Show();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
