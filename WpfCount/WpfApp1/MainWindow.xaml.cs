using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer;
        Timer timer1;
        int sec, h, m, s;
        public MainWindow()
        {
            InitializeComponent();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if(sec>0)
            {
                TimerText1.Text = sec+" seconds";
                sec--;
            }
            else
            {
                timer.Stop();
                TimerText1.Text = "Time's up!";
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            TimerText.Text = h + " :" + m + " :" + s;
            s++;
            if (s>60)
            {
                s = 0;
                m++;
                if (m > 60)
                {
                    m = 0;
                    h++;

                    if (h>23)
                    {
                        h = 0;
                    }
                }

            }
        }
        private void TimerBt_Click(object sender, RoutedEventArgs e)
        {
            if (sender == TimerBt)
            {
                sec = 10;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            else if(sender==TimerBt1)
            {
                sec = 10;
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer1_Tick);
                timer.Start();
            }
        }
    }
}
