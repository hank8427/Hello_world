using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        async private void CountTen()
        {
            for (int CountNumber = 0; CountNumber <= 10; CountNumber++)
            {
                labCount.Text = CountNumber.ToString();
                await Task.Delay(500);
            }
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            Action UpdateNumber = new Action(CountTen);
            Task DisplayNumber = new Task(UpdateNumber);
            DisplayNumber.Start();
        }

        async private void TimeChange()
        {
            while (true)
            {
                labDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                await Task.Delay(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Action UpdateTime = new Action(TimeChange);
            Task DisplayTime = new Task(UpdateTime);
            DisplayTime.Start();

        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
