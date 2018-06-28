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

namespace FunSeqWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewEraControl nec = new NewEraControl();
            nec.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ImageSeries myIS = new ImageSeries();
            myIS.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Test02 myTest02 = new Test02();
            myTest02.Show();
        }
    }
}