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
    /// Interaction logic for MisComisionesPagadas.xaml
    /// </summary>
    public partial class MisComisionesPagadas : Window
    {
        historialescomision miComision = new historialescomision();

        public MisComisionesPagadas()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuVendedor();
            abrir.Show();
            this.Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = miComision.mostrarComisionesPagadas();
            dgvComisionesPagadas.ItemsSource = lista;
        }
    }
}
