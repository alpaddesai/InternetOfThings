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

namespace InternetOfThings
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

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IoTData_Click(object sender, RoutedEventArgs e)
        {
            IoTDataManagementAnalytics IoTDataManagementAnalyticsObject = new IoTDataManagementAnalytics();
            IoTDataManagementAnalyticsObject.Show();
        }

        private void IoTApplications_Click(object sender, RoutedEventArgs e)
        {
            IoTApplications IoTApplicationsObject = new IoTApplications();
            IoTApplicationsObject.Show();
        }

        private void Emerging_Internet_of_Things_Click(object sender, RoutedEventArgs e)
        {
            NewAdvances NewAdvancesObject = new NewAdvances();
            NewAdvancesObject.Show();
        }
    }
}
