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
    /// Interaction logic for mostrarSaldo.xaml
    /// </summary>
    public partial class mostrarSaldo : Window
    {
        tblcaja miCaja = new tblcaja();

        public mostrarSaldo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int saldo = miCaja.mostrarSaldo();
            lblsaldo.Content = "Saldo actual es: $"+saldo;
        }
    }
}
