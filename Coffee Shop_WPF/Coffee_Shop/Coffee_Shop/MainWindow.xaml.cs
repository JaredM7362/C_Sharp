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

namespace Coffee_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Validation f1 = new Validation();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void b1_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void b2_btn_Click(object sender, RoutedEventArgs e)
        {
            methodPrint();
        }
        public void methodPrint()
        {
            try
            {
                PrintDialog dialog = new PrintDialog();
                if (dialog.ShowDialog() != true)
                    return;
                dialog.PrintVisual(txtDisplay, "IFMS Print Screen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Screen", MessageBoxButton.OK,
               MessageBoxImage.Error);
            }

        }

        private void b3_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            f1.Show();
        }
    }
}
