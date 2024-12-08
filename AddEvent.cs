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
    public partial class AddEvent : Form
    {
        public static string connString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = 'Database.mdb'";
        public static string metka;
        public bool load;
        public Form1 save_form { get; set; } 
        public AddEvent()
        {
            InitializeComponent();
        }
        public AddEvent(Form1 f)
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            int month = now.Month;
            int year = now.Year;
            int day = now.Day;
            txdate.Text = day + "." + month + "." + year;
            save_form = f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metka = txdate.Text;
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tbl_calendar ([date], [event]) VALUES (dat, eve)";
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("dat", txdate.Text);
            cmd.Parameters.AddWithValue("eve", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            load = true;
            cmd.Dispose();
            conn.Close();
            AddEvent form = this;
            form.Hide();
            save_form.daycontainer.Controls.Clear();
            save_form.displaDays();
        }
        
        private void AddEvent_Load(object sender, EventArgs e)
        {  
        }
    }
}
