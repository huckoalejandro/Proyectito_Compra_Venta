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
    /// Interaction logic for IngresarDinero.xaml
    /// </summary>
    public partial class IngresarDinero : Window
    {
        tblcaja miCaja = new tblcaja();
        public IngresarDinero()
        {
            InitializeComponent();
        }

        private void btningresarDinero_Click(object sender, RoutedEventArgs e)
        {
            int plata = Convert.ToInt32(txtingresarDinero.Text);
            miCaja.Agregar(plata);
            txtingresarDinero.Text = "";
            int saldo = miCaja.mostrarSaldo();
            txtlabeldinero.Content = "$" + saldo;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int saldo = miCaja.mostrarSaldo();
            txtlabeldinero.Content = ("$" + saldo);
        }
    }
}
