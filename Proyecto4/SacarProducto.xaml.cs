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
    /// Interaction logic for SacarProducto.xaml
    /// </summary>
    public partial class SacarProducto : Window
    {
        tblproducto miProducto = new tblproducto();
        public SacarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreStock = comboProductos.Text;
                int cantidadProductoVender = Convert.ToInt32(txtProductoSacar.Text);
                if (nombreStock == null || cantidadProductoVender == 0)
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    miProducto.Sacar(nombreStock, cantidadProductoVender);
                    int cantidad = miProducto.Stock(nombreStock);
                    lblStockDisponible.Content = "Stock Disponible:   " + cantidad;
                    txtProductoSacar.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtProductoSacar.Text = "";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var existencias = miProducto.Existencias();
            foreach (var prod in existencias)
            {
                comboProductos.Items.Add(prod.producto);
            }
        }
    }
}
