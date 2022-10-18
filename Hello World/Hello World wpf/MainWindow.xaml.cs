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
using System.Threading;

namespace Hello_World_wpf
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void btnSay_Click(object sender, RoutedEventArgs e)
        {
            labHelloWorld.Text = "Hello World!";
        }
        async private void CountTen()
        {
            for (int CountNumber = 0; CountNumber <= 10; CountNumber++)
            {
                labCount.Text = CountNumber.ToString();
                await Task.Delay(1000);
            }
        }
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            //Task.Run( async() =>
            //{
            //    for (int CountNumber = 0; CountNumber <= 10; CountNumber++)
            //    {
            //        labCount.Text = CountNumber.ToString();
            //        await Task.Delay(1000);
            //    }
            //});
            CountTen();
        }

        async private void DisplayTime()
        {
            while (true)
            {
                labDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                await Task.Delay(1000);
            }
        } 

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayTime();
        }
    }
}
