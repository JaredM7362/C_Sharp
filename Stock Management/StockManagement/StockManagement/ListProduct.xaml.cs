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

namespace StockManagement
{
    /// <summary>
    /// Interaction logic for ListProduct.xaml
    /// </summary>
    public partial class ListProduct : Window
    {
        string conString = @"Data Source=LAPTOP-6IMACERQ;Initial Catalog=StockSystem;Integrated Security=True";
        SqlConnection cnn;

        String sql1;
        SqlCommand cmd;
        


        public ListProduct()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadTable();
        }

        public void LoadTable()
        {
            try
            {
                cnn = new SqlConnection(conString);
                cnn.Open();

                string sql1 = "SELECT Category,Name,Cost,Selling,Quantity FROM Products";

                cmd = new SqlCommand(sql1, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Products");

                adapter.Fill(dt);
                adapter.Update(dt);
                ProductList.ItemsSource = dt.DefaultView;
  

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                cmd.Dispose();
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You have a problem" + ex.Message);
            }
        }


    }
}
