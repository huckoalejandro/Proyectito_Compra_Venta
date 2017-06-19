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
    /// Interaction logic for Registrar_Usuario.xaml
    /// </summary>
    public partial class Registrar_Usuario : Window
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
        }

        private void rbtnAdmin_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                var radioButton = sender as RadioButton;
                if (radioButton == null)
                    return;
                //var value = radioButton.GetValue().ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = txtnombreUsuario.Text;
            string contraseñaUsuario = txtContraseña.Text;
            string rolUsuario = "";


            if (rbtnAdmin.IsChecked == true)
            {
                rolUsuario = rbtnAdmin.Content.ToString();
            }
            else if (rbtnUsuario.IsChecked == true)
            {
                rolUsuario = rbtnUsuario.Content.ToString();
            }
            else if (rbtnAdminVEndedor.IsChecked == true)
            {
                rolUsuario = "VenAdmin";
            }
            bool textBoxVacios = false;
            if (txtnombreUsuario.Text == "" || txtContraseña.Text == "" && (rbtnAdmin.IsChecked == false || rbtnUsuario.IsChecked == false || rbtnAdminVEndedor.IsChecked == false))
            {
                textBoxVacios = true;
            }
            if (textBoxVacios == false)
            {
                var miUser = new tblusuario();
                miUser.nombreUsuario = nombreUsuario;
                miUser.clave = contraseñaUsuario;
                miUser.rolUsuario = rolUsuario;

                miUser.registrarUsuario(miUser);
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var alLogin = new MainWindow();
            alLogin.Show();
            this.Close();
        }
    }
}
