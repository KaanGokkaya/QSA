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
    /// Interaction logic for InTest.xaml
    /// </summary>
    public partial class InTest : Window
    {
        public InTest()
        {
            InitializeComponent();
        }

        private void End_Test_button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Testten Çıkış Yapılıyor. Onaylıyor musunuz ?", "InTest Screen", MessageBoxButton.YesNo, MessageBoxImage.None) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
