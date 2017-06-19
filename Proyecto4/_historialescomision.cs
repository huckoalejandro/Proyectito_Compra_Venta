using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto4
{
    public class historialescomision
    {
        
        Usuario miUsuario = new Usuario();

        public int mostrarComision(string nombreVendedor)
        {
            int comision = 0;
            try
            {
                var bd = new BD();
                var tablaComisionesV = bd.tblcomisionvendedor;
                foreach (var comisiones in tablaComisionesV)
                {
                    if (nombreVendedor == comisiones.tblusuario_nombreUsuario)
                    {
                        comision = comisiones.comision;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            return comision;

        }
        public void historialComisionesPagadas(string vendedor, int cantidadPagada)
        {
            var bd = new BD();
            DateTime fechaActual = DateTime.Today;
            var ingHistorial = new tblcomisionespagadas();
            ingHistorial.fecha = fechaActual;
            ingHistorial.comisionPagada = cantidadPagada;
            ingHistorial.tblusuario_nombreUsuario = vendedor;
            ingHistorial.ID = +1;
            bd.tblcomisionespagadas.Add(ingHistorial);
            bd.SaveChanges();
        }
        public void pagarComision(string nombre, int monto)
        {
            try
            {

                var bd = new BD();
                var tablaComisionesV = bd.tblcomisionvendedor;
                foreach (var comisiones in tablaComisionesV)
                {
                    if (nombre == comisiones.tblusuario_nombreUsuario)
                    {
                        comisiones.comision = comisiones.comision - monto;
                        historialComisionesPagadas(nombre, monto);

                    }
                }
                bd.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void comisionesVendedor(int saldo)
        {
            double comision = saldo * 5 / 100;
            string user = miUsuario.usuarioActual();
            var ingComision = new tblcomisionvendedor();
            ingComision.comision = Convert.ToInt32(comision);
            ingComision.tblusuario_nombreUsuario = user;
            bool userExiste = false;
            try
            {

                var bd = new BD();
                var tablaComisionesV = bd.tblcomisionvendedor;
                foreach (var comisiones in tablaComisionesV)
                {
                    if (user == comisiones.tblusuario_nombreUsuario)
                    {
                        comisiones.comision = comisiones.comision + Convert.ToInt32(comision);
                        userExiste = true;
                    }
                }
                if (userExiste == false)
                {
                    ingComision.id = +1;
                    bd.tblcomisionvendedor.Add(ingComision);

                }
                bd.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }


        }

        public List<tblcomisionvendedor> mostrarComisionesAdeudadas()
        {
            string user = miUsuario.usuarioActual();
            var lista = new List<tblcomisionvendedor>();
            var bd = new BD();
            try
            {
                var tablaComisionesAdeudadas = bd.tblcomisionvendedor;
                foreach (var comisiones in tablaComisionesAdeudadas)
                {
                    if (user == comisiones.tblusuario_nombreUsuario)
                    {
                        lista.Add(comisiones);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return lista;
        }
        public List<tblcomisionespagadas> mostrarComisionesPagadas()
        {
            var lista = new List<tblcomisionespagadas>();
            try
            {
                var bd = new BD();
                var tablaComisionesPagadas = bd.tblcomisionespagadas;
                foreach (var comisiones in tablaComisionesPagadas)
                {
                    lista.Add(comisiones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return lista;


        }
        public List<tblcomisionvendedor> mostrarComisionesVendedores()
        {
            var lista = new List<tblcomisionvendedor>();
            var bd = new BD();
            try
            {
                var tablaComisiones = bd.tblcomisionvendedor;
                foreach (var comisiones in tablaComisiones)
                {
                    lista.Add(comisiones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return lista;
        }
    }

}

