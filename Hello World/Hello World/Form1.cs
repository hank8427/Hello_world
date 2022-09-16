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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labHelloWorld.Text = "Hello World!";
        }

        Timer timer1 = new Timer();
        private int num = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    labCount.Text = i.ToString();
            //    System.Threading.Thread.Sleep(500);
            //    labCount.Update();
            //}
            timer1.Interval = 500;
            timer1.Start();
            timer1.Tick += new EventHandler(Count);
        }

        private void Count(object sender, EventArgs e)
        {
            if (num==10)
            {
                timer1.Stop();
            }
            else if(num<10)
            {
                num++;
                labCount.Text = num.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
            timer2.Tick += new EventHandler(DateTime_tick);

        }

        Timer timer2 = new Timer();
        private void DateTime_tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
