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

namespace StockManagement
{
    /// <summary>
    /// Interaction logic for Barcode.xaml
    /// </summary>
    public partial class Barcode : Window
    {
        public Barcode()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
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
                dialog.PrintVisual(_mainFrame, "IFMS Print Screen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Screen", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
