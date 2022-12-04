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

namespace QSA
{
    /// <summary>
    /// Interaction logic for settings_window.xaml
    /// </summary>
    public partial class settings_window : Window
    {
        public settings_window()
        {
            InitializeComponent();
        }

        private void Close_Button_Settings_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void testler_Click(object sender, RoutedEventArgs e)
        {
            CC_Settings.Content = new Testler_settings();
        }

        private void odevler_Click(object sender, RoutedEventArgs e)
        {
            CC_Settings.Content = new Odevler_settings();
        }

        private void Sayfa_Click(object sender, RoutedEventArgs e)
        {
            CC_Settings.Content = new Sayfa_settings();
        }

        private void contactMe_Click(object sender, RoutedEventArgs e)
        {
            CC_Settings.Content = new contact_me_settings();
        }
    }
}
