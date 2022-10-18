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

        private void btnCount_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                for (int CountNumber = 0; CountNumber <= 10; CountNumber++)
                {
                    labCount.Text = CountNumber.ToString();
                    Thread.Sleep(500);
                }
            }).Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.IsBackground = true;
            new Thread(() =>
            {
                while (true)
                {
                    labDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    Thread.Sleep(1000);
                }
            }).Start();
            
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
