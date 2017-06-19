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
    /// Interaction logic for VenderProducto.xaml
    /// </summary>
    public partial class VenderProducto : Window
    {
        tblproducto miProducto = new tblproducto();
        tblcaja miCaja = new tblcaja();

        public VenderProducto()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var existencias = miProducto.Existencias();
            foreach (var prod in existencias)
            {
                comboProductos.Items.Add(prod.producto);
            }
            int saldo = miCaja.mostrarSaldo();
            lblsaldoCaja.Content += " $ " + saldo;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreStock = comboProductos.Text;
                int stock = miProducto.Stock(nombreStock);

                lblStockDisponible.Content = "Stock Disponible: " + stock;


            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar un producto"); ;
            }
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreStock = comboProductos.Text;

                int cantidadProductoVender = Convert.ToInt32(txtcantidadProducto.Text);

                if (nombreStock == null || cantidadProductoVender == 0)
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    miProducto.venderProducto(nombreStock, cantidadProductoVender);
                    int nuevosaldo = miCaja.mostrarSaldo();
                    lblsaldoCaja.Content = "Saldo en caja: $" + nuevosaldo;
                    txtcantidadProducto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtcantidadProducto.Text = "";
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuVendedor();
            abrir.Show();
            this.Close();
        }
    }
}
