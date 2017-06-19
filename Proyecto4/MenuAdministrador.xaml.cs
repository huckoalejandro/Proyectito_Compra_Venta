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
    /// Interaction logic for MenuAdministrador.xaml
    /// </summary>
    public partial class MenuAdministrador : Window
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnCompraProdcutos_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new IngresarProducto();
            abrir.Show();
            this.Close();
        }

        private void btnVentaProductos_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new SacarProducto();
            abrir.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new InventarioAdmin();
            abrir.Show();
            this.Close();
        }

        private void btnOperacionesdeCaja_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new IngresarDinero();
            abrir.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new SacarDinero();
            abrir.Show();
            this.Close();
        }

        private void btnmostrarSaldo_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new mostrarSaldo();
            abrir.Show();
            this.Close();
        }

        private void btnhistorialCompras_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new HistorialCompras();
            abrir.Show();
            this.Close();
        }

        private void btnhistorialVentas_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new HistorialVentas();
            abrir.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new COMISIONES_POR__VENDEDOR();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new PagarComisiones();
            abrir.Show();
            this.Close();
        }

        private void btnregistrar_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new Registrar_Usuario();
            abrir.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MainWindow();
            abrir.Show();
            this.Close();
        }
    }
}
