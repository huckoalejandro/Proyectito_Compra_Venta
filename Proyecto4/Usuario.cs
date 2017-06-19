using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4
{
    public class Usuario
    {


        public void nombreUsuario(string nombre)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("UsuarioActual");
                escritor.WriteLine(nombre);
                escritor.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string usuarioActual()
        {
            string linea = "";
            try
            {
                StreamReader lector = new StreamReader("UsuarioActual");
                linea = lector.ReadLine();
                lector.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return linea;
        }
    }
}

