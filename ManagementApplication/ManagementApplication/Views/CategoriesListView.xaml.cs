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
    /// Interaction logic for CategoriesListView.xaml
    /// </summary>
    public partial class CategoriesListView : UserControl
    {
        string connectionString = "Server=DESKTOP-THB3Q4D\\SQLEXPRESS;Database=ExampleDB;Integrated Security=True";
        public CategoriesListView()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            string query = "SELECT * FROM Categories";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgCategory.ItemsSource = dataTable.DefaultView;
        }

        private void InsertCategorie(string CatName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Categories ( CatName) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", CatName);
                
                command.ExecuteNonQuery();
            }
            LoadCategories();
        }
        private void Add_Category_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InsertCategorie(txtCategoryName.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteCategory(int Catid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Categories WHERE CatCode = @CatCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CatCode", Catid);
                command.ExecuteNonQuery();
            }
            LoadCategories(); // Reload DataGridView after deletion
        }

        private void Delete_Category_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                DeleteCategory(int.Parse(txtCategoryCode.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void UpdateCategory(int CatId, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Categories SET CatName = @Name WHERE CatCode = @CatId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@CatId", CatId);
                command.ExecuteNonQuery();
            }
            LoadCategories();  // Reload DataGridView after update
        }

        private void Edit_Category_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                UpdateCategory(int.Parse(txtCategoryCode.Text), txtCategoryName.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCategory.SelectedItem != null)
            {
                // Récupérer l'élément sélectionné depuis le DataGrid
                DataRowView row = (DataRowView)dgCategory.SelectedItem;

                // Mettre à jour les TextBoxes avec les détails de l'élément sélectionné
                txtCategoryCode.Text = row[0].ToString();
                txtCategoryName.Text = row["CatName"].ToString();

            }
        }

        private void txtCategoryName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
