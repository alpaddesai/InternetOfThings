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

namespace InternetOfThings
{
    /// <summary>
    /// Interaction logic for NewAdvances.xaml
    /// </summary>
    public partial class NewAdvances : Window
    {
        public NewAdvances()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void HealthCare_Click(object sender, RoutedEventArgs e)
        {
            HealthCareSystemMap HealthCareSystemMapObject = new HealthCareSystemMap();
            HealthCareSystemMapObject.Show();
        }
    }
}
