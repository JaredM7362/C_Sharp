using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string conString = @"Data Source=LAPTOP-6IMACERQ;Initial Catalog=StockSystem;Integrated Security=True";
        SqlConnection cnn;

        String sql1;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        ListProduct f1 = new ListProduct();
        Barcode f2 = new Barcode();
        public MainWindow()
        {
            InitializeComponent();

           
        }



        public void AddProduct()
        {
            try 
            { 

                String Category = comboCategory.Text;
                String Name = txtProduct.Text;
                float Cost = float.Parse(txtCost.Text);
                float Selling = float.Parse(txtSelling.Text);
                int Quantity = int.Parse(txtQuantity.Text);
                String barcode = txtBarcode.Text;

                sql1 = "INSERT into dbo.Products (Category,Name,Cost,Selling,Quantity,Barcode) Values " +
                    "('" + Category + "', '" + Name + "', '" + Cost + "', '" + Selling + "' , '" + Quantity + "','"+barcode+"'  )";

 

                cnn = new SqlConnection(conString);
                cnn.Open();

                cmd = new SqlCommand(sql1, cnn);
                adapter.InsertCommand = cmd;
                

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
                if (Quantity > 5)
                {
                    MessageBox.Show("Stock is low");
                }
                cmd.Dispose();
                cnn.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You have a problem" + ex.Message);
            }

        }

        public void DeleteProduct()
        {
            try
            {
                cnn = new SqlConnection(conString);
                cnn.Open();

                string sql1 = "Delete from Products where Name = '" + this.txtProduct.Text + "' ";

                cmd = new SqlCommand(sql1, cnn);
                



                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You have a problem" + ex.Message);
            }
        }

        public void UpdateProduct()
        {
            try
            {
                cnn = new SqlConnection(conString);
                cnn.Open();

                string sql1 = "update Products set Category = '" + this.comboCategory.Text + "', " +
                    "Name = '" + this.txtProduct.Text + "' , " +
                    "Cost = '"+ this.txtCost.Text+ "', " +
                    "Selling = '"+this.txtSelling.Text+"'";

                cmd = new SqlCommand(sql1, cnn);




                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You have a problem" + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddProduct();
            f1.Show();
            this.Close();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            f1.Show();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteProduct();
            f1.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateProduct();
            f1.Show();
            this.Close();
        }

        private void btnBarcode_Click(object sender, RoutedEventArgs e)
        {
            f2.Show();
            this.Close();
        }
    }
}
