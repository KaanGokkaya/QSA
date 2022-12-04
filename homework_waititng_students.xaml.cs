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
    /// Interaction logic for homework_waititng_students.xaml
    /// </summary>
    public partial class homework_waititng_students : Window
    {
        public homework_waititng_students()
        {
            InitializeComponent();
        }

        private void Close_homeworkScreen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Start_Solving(object sender, RoutedEventArgs e)
        {
            this.Close();
            InHomework homework_screen = new InHomework();
            homework_screen.Show();
        }
    }
}
