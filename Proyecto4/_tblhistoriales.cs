using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto4
{
    public partial class tblhistoriales
    {
        Usuario miUsuario = new Usuario();
        public void historialVenta(int cantidad, int total, string producto)
        {
            var bd = new BD();
            DateTime fechaActual = DateTime.Today;

            string user = miUsuario.usuarioActual();
            var ingHistorial = new tblhistorialventa();
            ingHistorial.fecha = fechaActual;
            ingHistorial.cantidad = cantidad;
            ingHistorial.totalVenta = total;
            ingHistorial.nombreVendedor = user;
            ingHistorial.tblproducto_producto = producto;
            ingHistorial.ID = +1;
            bd.tblhistorialventa.Add(ingHistorial);
            bd.SaveChanges();
        }
        public void historialCompra(int cantidad, int total, string producto)
        {
            var bd = new BD();
            DateTime fechaActual = DateTime.Today;
            string user = miUsuario.usuarioActual();
            var ingHistorial = new tblhistorialcompra();
            ingHistorial.fecha = fechaActual;
            ingHistorial.cantidad = cantidad;
            ingHistorial.totalCompra = total;
            ingHistorial.tblusuario_nombreUsuario = user;
            ingHistorial.tblproducto_producto = producto;
            ingHistorial.ID = +1;
            bd.tblhistorialcompra.Add(ingHistorial);
            bd.SaveChanges();

        }
        public List<tblhistorialventa> mostrarHistorialVentas()
        {
            var lista = new List<tblhistorialventa>();
            var bd = new BD();
            try
            {
                var tablaHistorial = bd.tblhistorialventa;
                foreach (var historial in tablaHistorial)
                {
                    lista.Add(historial);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return lista;
        }
        public List<tblhistorialcompra> mostrarHistorialCompras()
        {
            var lista = new List<tblhistorialcompra>();
            var bd = new BD();
            try
            {
                var tablaHistorial = bd.tblhistorialcompra;
                foreach (var historial in tablaHistorial)
                {
                    lista.Add(historial);
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
