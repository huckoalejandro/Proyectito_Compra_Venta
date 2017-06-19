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

namespace Proyecto4
{
    /// <summary>
    /// Interaction logic for MenuVendedor.xaml
    /// </summary>
    public partial class MenuVendedor : Window
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new VenderProducto();
            abrir.Show();
            this.Close();
        }

        private void btnVentaProductos_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new ComprarProducto();
            abrir.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new COMISIONES_ADEUDADAS();
            abrir.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MisComisionesPagadas();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MainWindow();
            abrir.Show();
            this.Close();
        }
    }
}
