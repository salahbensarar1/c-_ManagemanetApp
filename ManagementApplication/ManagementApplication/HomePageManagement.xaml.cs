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
            ItemsListView itemsListView = new ItemsListView();
            this.Content = itemsListView;
        }

        private void Category_Butt_Click(object sender, RoutedEventArgs e)
        {
            CategoriesListView categoriesListView = new CategoriesListView();
            this.Content = categoriesListView;
        }

        private void Customer_Butt_Click(object sender, RoutedEventArgs e)
        {
            CustomersListView customersListView = new CustomersListView();
            this.Content = customersListView;
        }

        private void Billing_Butt_Click(object sender, RoutedEventArgs e)
        {
            BillingsListView billingsListView = new BillingsListView();
            this.Content = billingsListView;
        }
    }
}
