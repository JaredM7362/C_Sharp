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
using System.Data;
using System.IO;

namespace Coffee_Shop
{
    /// <summary>
    /// Interaction logic for Validation.xaml
    /// </summary>
    public partial class Validation : Window
    {
        string conString = @"Data Source=LAPTOP-6IMACERQ;Initial Catalog=CoffeShopDB;Integrated Security=True";
        SqlConnection cnn;
        String sql1;
        SqlCommand cmd;

        public Validation()
        {
            InitializeComponent();
        }

        private void Confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            BackUpFile();
            /// Call Validation Method
            Login();
        }

        /// Validation Method
        public void Login()
        {
            sql1 = "Select * from ManagerTable Where Username = '"+ txtUser.Text +"' and  Password = '"+ txtPass.Text +"'";

            cnn = new SqlConnection(conString);

            SqlDataAdapter adapter = new SqlDataAdapter(sql1, cnn);
            DataTable dtb1 = new DataTable();

            adapter.Fill(dtb1);

            if (dtb1.Rows.Count == 1)
            {
                MessageBox.Show("Login Successful");

                MainWindow main = new MainWindow();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
            }
        }

        public void BackUpFile()
        {
            string user, time;
            
            user = txtUser.Text;
            time = DateTime.Now.ToString("dddd, dd-MM-yyyy");

            File.AppendAllText(@"C:/Users/Jared Moodley/OneDrive/Documents/SD_2022/PRG512_C#/Summative/BackUpSale.txt ", "Date: " + time + "\n\n");

            File.AppendAllText(@"C:/Users/Jared Moodley/OneDrive/Documents/SD_2022/PRG512_C#/Summative/BackUpSale.txt ","Username: " + user + "\n");
            File.AppendAllText(@"C:/Users/Jared Moodley/OneDrive/Documents/SD_2022/PRG512_C#/Summative/BackUpSale.txt ","Password: " + txtPass.Text + "\n\n");



        }
    }
}
