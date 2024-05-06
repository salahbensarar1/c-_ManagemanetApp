using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace ManagementApplication.Views
{
    /// <summary>
    /// Interaction logic for CustomersListView.xaml
    /// </summary>
    public partial class CustomersListView : UserControl
    {
        string connectionString = "Server=DESKTOP-THB3Q4D\\SQLEXPRESS;Database=ExampleDB;Integrated Security=True";
        public CustomersListView()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void InsertCustomers(string CustName,string CustGender, string CustPhone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Customers ( CustName,CustGender,CustPhone) VALUES (@Name,@gender,@phone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", CustName);
                command.Parameters.AddWithValue("@gender", CustGender);
                command.Parameters.AddWithValue("@phone", CustPhone);

                command.ExecuteNonQuery();
            }
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            string query = "SELECT * FROM Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgCustomers.ItemsSource = dataTable.DefaultView;
        }
        
        private void Add_customer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InsertCustomers(txtCustomerName.Text,txtCustomergender.Text,txtCustomerphone.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }





        private void DeleteCustomer(int Custid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Customers WHERE CustCode = @CustCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustCode", Custid);
                command.ExecuteNonQuery();
            }
            LoadCustomers(); // Reload DataGridView after deletion
        }

        private void Delete_Customer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeleteCustomer(int.Parse(txtCustomerCode.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void UpdateCategory(int CustId,string name,string gender,string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Customers SET CustName = @name, CustGender = @gender, CustPhone = @phone WHERE CustCode = @CustId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@CustId", CustId);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@phone", phone);
                command.ExecuteNonQuery();
            }
            LoadCustomers();  // Reload DataGridView after update
        }


        private void Edit_Customer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateCategory(int.Parse(txtCustomerCode.Text), txtCustomerName.Text, txtCustomergender.Text, txtCustomerphone.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCustomers.SelectedItem != null)
            {
                // Récupérer l'élément sélectionné depuis le DataGrid
                DataRowView row = (DataRowView)dgCustomers.SelectedItem;

                // Mettre à jour les TextBoxes avec les détails de l'élément sélectionné
                txtCustomerCode.Text = row[0].ToString();
                txtCustomergender.Text = row["CustGender"].ToString();
                txtCustomerName.Text = row["CustName"].ToString();
                txtCustomerphone.Text = row["CustPhone"].ToString();

            }
        }
    }
}
