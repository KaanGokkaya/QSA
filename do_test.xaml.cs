using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for do_test.xaml
    /// </summary>
    public partial class do_test : UserControl
    {
        public do_test()
        {
            InitializeComponent();
        }

        private void Refresh_button_Click(object sender, RoutedEventArgs e)
        {
            question_count_search.Text = "";
            test_name_search.Text = "";
        }

        private void Question_Count_Number_Check(object sender, TextChangedEventArgs e)
        {

        }

        private void Start_test_button_Cick(object sender, RoutedEventArgs e)
        {
            waiting_students waiting_screen = new waiting_students();
            waiting_screen.Show();
        }
    }
}
