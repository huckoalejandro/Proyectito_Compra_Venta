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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        tblusuario miUser = new tblusuario();
        Usuario miUsuario = new Usuario();
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            string nombreUser = txtusuario.Text;
            string pass = txtcontraseña.Password;
            string rol = miUser.mostrarRol(nombreUser, pass);
            if (rol == "Administrador")
            {
                var abrir = new MenuAdministrador();
                abrir.Show();
                this.Close();
            }
            else if (rol == "Vendedor")
            {
                miUsuario.nombreUsuario(nombreUser);
                var abrir = new MenuVendedor();
                abrir.Show();
                this.Close();


            }
            else if (rol == "VenAdmin")
            {
                miUsuario.nombreUsuario(nombreUser);
                var abrir = new MenuVendedorAdministrador();
                abrir.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("El usuario o contraseña no son validos.");
                txtusuario.Text = "";
                txtcontraseña.Password = "";
            }
        }

        private void btnrecuperar_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new EditarUsuario();
            abrir.Show();
            this.Close();
        }
    }
}
