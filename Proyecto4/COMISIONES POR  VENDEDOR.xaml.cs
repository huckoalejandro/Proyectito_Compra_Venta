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
    /// Interaction logic for COMISIONES_POR__VENDEDOR.xaml
    /// </summary>
    public partial class COMISIONES_POR__VENDEDOR : Window
    {
        public COMISIONES_POR__VENDEDOR()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            historialescomision miComision = new historialescomision();
            var lista = miComision.mostrarComisionesVendedores();
            dgvComisionesVendedor.ItemsSource = lista;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }
    }
}
