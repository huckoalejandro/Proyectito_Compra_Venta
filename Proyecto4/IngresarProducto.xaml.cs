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
    /// Interaction logic for IngresarProducto.xaml
    /// </summary>
    public partial class IngresarProducto : Window
    {
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            bool textBoxVacios = false;
            if (txtnombreIngresar.Text == "" || txtprecioCompra.Text == "" || txtcantidad.Text == "" || txtprecioVenta.Text == "")
            {
                textBoxVacios = true;
            }
            if (textBoxVacios == false)
            {
                string nombreProducto = txtnombreIngresar.Text;
                int precioCompra = Convert.ToInt32(txtprecioCompra.Text);
                int precioVenta = Convert.ToInt32(txtprecioVenta.Text);
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                var miProducto = new tblproducto();

                miProducto.producto = nombreProducto;
                miProducto.precioCompra = precioCompra;
                miProducto.precioVenta = precioVenta;
                miProducto.cantidad = cantidad;
                miProducto.Agregar(miProducto);
                txtnombreIngresar.Text = "";
                txtprecioCompra.Text = "";
                txtprecioVenta.Text = "";
                txtcantidad.Text = "";

            }
        }
    }
}
