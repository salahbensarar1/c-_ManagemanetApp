
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace ManagementApplication.Views
{
    /// <summary>
    /// Interaction logic for ItemsListView.xaml
    /// </summary>
    public partial class ItemsListView : UserControl
    {
        string connectionString = "Server=DESKTOP-THB3Q4D\\SQLEXPRESS;Database=ExampleDB;Integrated Security=True";
        public ItemsListView()
        {
            InitializeComponent();
            Loadcategori();
            LoadItems();
        }


        private void Loadcategori()
        {
            // Connexion à la base de données et récupération des données
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CatName FROM Categories";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<string> itemsList = new List<string>();

                while (reader.Read())
                {
                    string itemName = reader["CatName"].ToString();
                    itemsList.Add(itemName);
                }

                cmbItems.ItemsSource = itemsList;
            }
        }
            //Clear 
          

        private void LoadItems()
        {
            string query = "SELECT * FROM items";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgItems.ItemsSource = dataTable.DefaultView;
        }

        private void InsertItems(string txtItemName, string CATEGORIE, string txtPrice,string txtStock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Items ( ItemsName,ItCategory,ItemsPrice,ItemsStock) VALUES (@Name,@cat,@price,@stock)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtItemName);
                command.Parameters.AddWithValue("@cat", CATEGORIE);
                command.Parameters.AddWithValue("@price", txtPrice);
                command.Parameters.AddWithValue("@stock", txtStock);

                command.ExecuteNonQuery();
                connection.Close();//tatsd coneection f dakshi lakhor 
            }
            LoadItems();
        }

        private void Add_Item_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InsertItems(txtItemName.Text, cmbItems.Text, txtPrice.Text, txtStock.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void DeleteItem(int ItCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Items WHERE ItCode = @ItCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItCode", ItCode);
                command.ExecuteNonQuery();
            }
            LoadItems(); // Reload DataGridView after deletion
        }


        private void Delete_Item_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeleteItem(int.Parse(txtItemCode.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateItem(int ItCode,string Itname, string itCat, string itPrice, string itStock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Items SET ItemsName = @ItemsName, ItCategory = @ItCategory, ItemsPrice = @ItemsPrice, ItemsStock = @ItemsStock WHERE ItCode = @ItCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemsName", Itname);
                command.Parameters.AddWithValue("@ItCategory", itCat);
                command.Parameters.AddWithValue("@ItemsPrice", itPrice);
                command.Parameters.AddWithValue("@ItemsStock", itStock);
                command.Parameters.AddWithValue("@ItCode", ItCode);
                
                command.ExecuteNonQuery();
            }
            LoadItems();  // Reload DataGridView after update
        }

        private void Edit_Item_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateItem(int.Parse(txtItemCode.Text),txtItemName.Text, cmbItems.Text,txtPrice.Text, txtStock.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgItems.SelectedItem != null)
            {
                // Récupérer l'élément sélectionné depuis le DataGrid
                DataRowView row = (DataRowView)dgItems.SelectedItem;

                // Mettre à jour les TextBoxes avec les détails de l'élément sélectionné
                txtItemCode.Text = row[0].ToString();
                txtItemName.Text = row["ItemsName"].ToString();
                cmbItems.Text =  row["ItCategory"].ToString();
                txtPrice.Text = row["ItemsPrice"].ToString();
                txtStock.Text = row["ItemsStock"].ToString();
                
            }
        }
    }
}

