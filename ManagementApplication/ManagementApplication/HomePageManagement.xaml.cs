using ManagementApplication.Views;
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

namespace ManagementApplication
{
    /// <summary>
    /// Interaction logic for HomePageManagement.xaml
    /// </summary>
    public partial class HomePageManagement : Window
    {
        public HomePageManagement()
        {
            InitializeComponent();
        }
        private void Items_Butt_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Views/ItemsListView.xaml", UriKind.Relative));
        }

        private void Category_Butt_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Views/CategoriesListView.xaml", UriKind.Relative));
        }

        private void Customer_Butt_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Views/CustomersListView.xaml", UriKind.Relative));
        }

        private void Billing_Butt_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Views/BillingsListView.xaml", UriKind.Relative));
        }
    }
}
