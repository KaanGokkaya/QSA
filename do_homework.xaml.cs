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
    /// Interaction logic for do_homework.xaml
    /// </summary>
    public partial class do_homework : UserControl
    {
        public do_homework()
        {
            InitializeComponent();
        }

        private void result_addStatistic_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Open_result_addStatistic_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Close_result_addStatistic_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Homework_Start_Clicked(object sender, RoutedEventArgs e)
        {
            homework_waititng_students waiting_screen = new homework_waititng_students();
            waiting_screen.Show();
        }
    }
}
