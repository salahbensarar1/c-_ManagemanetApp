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
using System.Data.SqlClient;

namespace ManagementApplication
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-THB3Q4D\\SQLEXPRESS;Database=ExampleDB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string add_data = "INSERT INTO [dbo].[user] (username, password) VALUES (@username, @password)";
                    using (SqlCommand cmd = new SqlCommand(add_data, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Password);
                        cmd.ExecuteNonQuery();
                        username.Text = "";
                        password.Password = "";
                        MainWindow m1 = new MainWindow();
                        this.Close();
                        m1.Show();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomePageManagement H1 = new HomePageManagement();  
            this.Close();
            H1.Show();
        }
    }
}
