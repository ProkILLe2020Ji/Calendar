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

namespace Calendr
{
    public partial class EventForm : Form
    {
        public static string connString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = 'Database.mdb'";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.tbl_calendar". При необходимости она может быть перемещена или удалена.
            this.tbl_calendarTableAdapter.Fill(this.databaseDataSet.tbl_calendar);
            txdate.Text = UserControlDays.static_day + "." + Form1.static_month + "." + Form1.static_year;
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            String sql = "SELECT event FROM tbl_calendar WHERE date = dat";
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("dat", UserControlDays.static_day + "." + Form1.static_month + "." + Form1.static_year);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<string> data = new List<string>();
            while (reader.Read())
            {
                data.Add(reader["event"].ToString());
            }
            foreach (string dat in data)
            {
                Event ev = new Event();
                ev.displayEvent(dat);
                panel1.Controls.Add(ev);
            }
            conn.Dispose();
            reader.Dispose();
            conn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            EventForm form = this;
            form.Hide();
        }
    }
}
