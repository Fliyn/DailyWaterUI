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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        MySqlConnection sql = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=realwaterui");
        private void Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (Button1.Checked)
            {
                UserControl5.BringToFront();
            }
        }

        private void Button2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (Button3.Checked)
            {
                UserControl7.BringToFront();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            sql.Open();
            string y = "UPDATE market SET kullanılabilirlik=0  where kullanılabilirlik=1";
            MySqlCommand xmd = new MySqlCommand(y, sql);
            xmd.CommandText = y;
            xmd.ExecuteNonQuery();
            sql.Close();
        }
    }
}
