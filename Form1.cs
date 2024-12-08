using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;


namespace Calendr
{
    public partial class Form1 : Form
    {
        int month, year;
        public static int static_month, static_year;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        public void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = Monthname(monthname) + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                ucdays.displayEvent(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        
        private void Next_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = Monthname(monthname) + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                ucdays.displayEvent(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            AddEvent form = new AddEvent(this);
            form.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma = this;
            forma.Close();
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = Monthname(monthname) + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                ucdays.displayEvent(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private string Monthname(string str)
        {
            char[] letters = str.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
