using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for BillingsListView.xaml
    /// </summary>
    public partial class BillingsListView : UserControl
    {
        string connectionString = "Server=DESKTOP-THB3Q4D\\SQLEXPRESS;Database=ExampleDB;Integrated Security=True";
        public BillingsListView()
        {
            InitializeComponent();
        }

        public void listbilling()
        {
            string req = "select * from Billing";
            SqlDataAdapter da = new SqlDataAdapter(req,connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgBillings.ItemsSource = dt.DefaultView;
        }
        private void InsertBilling(string name, decimal totalAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Billing (Name, TotalAmount) VALUES (@Name, @TotalAmount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.ExecuteNonQuery();
            }
            listbilling();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //code ra dayro auto increment andiro aybda b 1 o aybqa ytzad b1
                InsertBilling(txtCustomerName.Text,int.Parse(txtTotalAmount.Text));
                listbilling();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgBillings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgBillings.SelectedItem != null)
            {
                // Récupérer l'élément sélectionné depuis le DataGrid
                DataRowView row = (DataRowView)dgBillings.SelectedItem;

                // Mettre à jour les TextBoxes avec les détails de l'élément sélectionné
                txtBillingCode.Text = row[0].ToString();
                txtCustomerName.Text = row["Name"].ToString();
                txtTotalAmount.Text = row["TotalAmount"].ToString();
               
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            listbilling();
        }
        private void UpdateBilling(int billingId, string name, decimal totalAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Billing SET Name = @Name, TotalAmount = @TotalAmount WHERE BillingCode = @BillingCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@BillingCode", billingId);
                command.ExecuteNonQuery();
            }
            listbilling();  // Reload DataGridView after update
        }
        private void Edit_Billing_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                
                UpdateBilling(int.Parse(txtBillingCode.Text), txtCustomerName.Text, int.Parse(txtTotalAmount.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteBilling(int billingId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Billing WHERE BillingCode = @BillingCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BillingCode", billingId);
                command.ExecuteNonQuery();
            }
            listbilling(); // Reload DataGridView after deletion
        }
        private void Delete_Billing_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                DeleteBilling(int.Parse(txtBillingCode.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

