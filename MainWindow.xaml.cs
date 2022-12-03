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

namespace QSA
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

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("QSA Kapatılıcak. Onaylıyor musunuz ?","QSA",MessageBoxButton.YesNo,MessageBoxImage.None) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Down_Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Do_test_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new do_test();
        }

        private void qsa_button_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Base();
        }

        private void Homework_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Statistic_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Upload_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Setting_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
