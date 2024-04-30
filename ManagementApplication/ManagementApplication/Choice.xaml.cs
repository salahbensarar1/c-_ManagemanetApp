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
    /// Interaction logic for Choice.xaml
    /// </summary>
    public partial class Choice : Window
    {
        public Choice()
        {
            InitializeComponent();
        }

        
        private void Go_ToManage_Click(object sender, RoutedEventArgs e)
        {
            HomePageManagement H11 = new HomePageManagement();
            this.Close();
            H11.Show();
        }

        
        private void Register_From_Choice_page_Click(object sender, RoutedEventArgs e)
        {
            Register R11 = new Register();
            this.Close();
            R11.Show();

        }
    }
}
