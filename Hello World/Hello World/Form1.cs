using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        private int Count_num = 0;

        Timer CountTen_timer = new Timer();
        Timer DateTime_timer = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labHelloWorld.Text = "Hello World!";
        }

        private void CountTen(object sender, EventArgs e)
        {
            if (Count_num == 10)
            {
                CountTen_timer.Stop();
            }
            else if (Count_num < 10)
            {
                Count_num++;
                labCount.Text = Count_num.ToString();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            CountTen_timer.Interval = 500;
            CountTen_timer.Start();
            CountTen_timer.Tick += new EventHandler(CountTen);
        }

        private void Time_Change_Interval(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime_timer.Enabled = true;
            DateTime_timer.Start();
            DateTime_timer.Tick += new EventHandler(Time_Change_Interval);

        }
    }
}
