using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Calendr
{
    public partial class UserControlDays : UserControl
    {
        public static string connString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = 'Database.mdb'";
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
        }
        public void displayEvent(int numday)
        {
            if (numday > 0)
            {
                OleDbConnection conn = new OleDbConnection(connString);
                conn.Open();
                String sql = "SELECT * FROM tbl_calendar WHERE date = dat";
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("dat", numday + "." + Form1.static_month + "." + Form1.static_year);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = "У вас записаны события!";
                }
                reader.Dispose();
                cmd.Dispose();
                conn.Close();
                
            }
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventform = new EventForm();
            eventform.Show();
        }
    }
}
