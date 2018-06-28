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
using System.Windows.Shapes;

namespace FunSeqWPF
{
    /// <summary>
    /// Interaction logic for Test02.xaml
    /// </summary>
    public partial class Test02 : Window
    {
        public Test02()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You left");
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked twice");
        }

        private void Button_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show("You scrolled");
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You picked a date");
        }

        private void Slider_TouchLeave(object sender, TouchEventArgs e)
        {
            MessageBox.Show("You have a number");
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MessageBox.Show("Different number");
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("yay you got orange");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("yay");
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("circles are good");
        }

        private void PasswordBox_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("enter a password (;");
        }

        private void PasswordBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("kthxbye");
        }

        private void ScrollBar_Drop(object sender, DragEventArgs e)
        {
            MessageBox.Show("cool");
        }

        private void Rectangle_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show("n  i  c  e");
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
