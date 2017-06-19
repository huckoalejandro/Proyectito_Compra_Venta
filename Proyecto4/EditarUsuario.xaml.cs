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
    /// Interaction logic for EditarUsuario.xaml
    /// </summary>
    public partial class EditarUsuario : Window
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = txtnombreUsuario.Text;
            string contraseñaUsuario = txtContraseña.Text;
            bool textBoxVacios = false;
            if (txtnombreUsuario.Text == "" || txtContraseña.Text == "")
            {
                textBoxVacios = true;
            }
            if (textBoxVacios == false)
            {
                var miEditar = new tblusuario();
                miEditar.editarUsuario(nombreUsuario, contraseñaUsuario);
                txtnombreUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else if (textBoxVacios == true)
            {
                MessageBox.Show("Debe rellenar todos los campos.");
                txtnombreUsuario.Text = "";
                txtContraseña.Text = "";
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var alLogin = new MainWindow();
            alLogin.Show();
            this.Close();
        }
    }
}
