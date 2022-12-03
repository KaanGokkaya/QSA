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
    /// Interaction logic for waiting_students.xaml
    /// </summary>
    public partial class waiting_students : Window
    {
        public waiting_students()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            this.Close();
            InTest testUI = new InTest();
            testUI.Show();
        }

        private void ExittheTest_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
