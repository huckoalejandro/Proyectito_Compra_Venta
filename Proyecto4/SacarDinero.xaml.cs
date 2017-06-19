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
    /// Interaction logic for SacarDinero.xaml
    /// </summary>
    public partial class SacarDinero : Window
    {
        tblcaja miCaja = new tblcaja();
        public SacarDinero()
        {
            InitializeComponent();
        }

        private void btnsacarDinero_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int plata = Convert.ToInt32(txtsacarDinero.Text);
                miCaja.Sacar(plata);
                int saldo = miCaja.mostrarSaldo();
                txtlabeldinero.Content = ("$" + saldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debe ingresar cantidad de dinero que desea sacar.");
            }
            txtsacarDinero.Text = "";
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
