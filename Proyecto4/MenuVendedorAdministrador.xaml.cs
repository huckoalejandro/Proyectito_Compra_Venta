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
    /// Interaction logic for MenuVendedorAdministrador.xaml
    /// </summary>
    public partial class MenuVendedorAdministrador : Window
    {
        public MenuVendedorAdministrador()
        {
            InitializeComponent();
        }

        private void btnmenuAdministrador_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuAdministrador();
            abrir.Show();
            this.Close();
        }

        private void btnmenuVendedor_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MenuVendedor();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new MainWindow();
            abrir.Show();
            this.Close();
        }
    }
}
