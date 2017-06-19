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
    /// Interaction logic for PagarComisiones.xaml
    /// </summary>
    public partial class PagarComisiones : Window
    {
        historialescomision miComision = new historialescomision();
        public PagarComisiones()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreVendedor = cbnombreVendedor.Text;
                int comision = miComision.mostrarComision(nombreVendedor);
                label_Copy.Content = "Total Comisiones: $" + comision;

            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar un producto"); ;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreVendedor = cbnombreVendedor.Text;

                int cantidadPagarComision = Convert.ToInt32(txtPagarComision.Text);

                if (nombreVendedor == null || cantidadPagarComision <= 0)
                {
                    MessageBox.Show("Debe rellenar todos los campos.");
                }
                else
                {
                    miComision.pagarComision(nombreVendedor, cantidadPagarComision);
                    txtPagarComision.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtPagarComision.Text = "";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = miComision.mostrarComisionesVendedores();
            foreach (var user in lista)
            {
                cbnombreVendedor.Items.Add(user.tblusuario_nombreUsuario);
            }
        }
    }
}
