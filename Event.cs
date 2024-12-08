using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendr
{
    public partial class Event : UserControl
    {
        public Event()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {

        }
        public void displayEvent(string txt)
        {
            textBox1.Text = txt;
        }
    }
}
