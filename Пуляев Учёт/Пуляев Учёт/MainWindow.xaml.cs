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

namespace Пуляев_Учёт
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
            if (tt1.Text=="1"||tt2.Text=="1")
            {
                Window1 a = new Window1();
                a.Show();
                this.Close();
            }
           else if(tt2.Text=="2"||tt2.Text=="2")
            {
                Window2 a = new Window2();
                a.Show();
                this.Close();
            }
         else if(tt2.Text == "3" || tt2.Text == "3")
            {
                Window3 a = new Window3();
                a.Show();
                this.Close();
            }
           
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void tt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
