using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
namespace Proyecto4
{
    public partial class tblusuario
    {

        public void editarUsuario(string nombre, string contraseña)
        {
            bool usuarioExiste = false;
            try
            {
                var bd = new BD();
                var usuario = bd.tblusuario;
                foreach (var registro in usuario)
                {
                    if (registro.nombreUsuario == nombre)
                    {
                        usuarioExiste = true;
                        registro.clave = contraseña;

                    }
                }
                bd.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            if (usuarioExiste == false)
            {
                MessageBox.Show("El usuario no existe.");
            }

        }
        public void registrarUsuario(tblusuario regUsuario)
        {
            try
            {

                var bd = new BD();
                var tablaUsuario = bd.tblusuario;
                bool usuarioExiste = false;
                foreach (var usuarios in tablaUsuario)
                {
                    if (regUsuario.nombreUsuario == usuarios.nombreUsuario)
                    {
                        usuarioExiste = true;
                    }
                }
                if (usuarioExiste == false)
                {
                    bd.tblusuario.Add(regUsuario);
                }

                else
                {
                    MessageBox.Show("El usuario existe");
                }
                bd.SaveChanges();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public string mostrarRol(string nombre, string pass)
        {
            bool usuarioExiste = false;
            string rolactual = "";
            try
            {


                var bd = new BD();
                var tablausuario = bd.tblusuario;
                foreach (var usuarios in tablausuario)
                {
                    if (nombre == usuarios.nombreUsuario)
                    {
                        usuarioExiste = true;
                        if (pass == usuarios.clave)
                        {
                            rolactual = usuarios.rolUsuario;

                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                if (usuarioExiste == false)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            return rolactual;
        }
    }
}
