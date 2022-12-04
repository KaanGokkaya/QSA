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
    /// Interaction logic for InHomework.xaml
    /// </summary>
    public partial class InHomework : Window
    {
        public InHomework()
        {
            InitializeComponent();
        }

        private void End_Test_button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Ödevden Çıkış Yapılıyor. Onaylıyor musunuz ?", "InHomework Screen", MessageBoxButton.YesNo, MessageBoxImage.None) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
