using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto4
{
    public partial class tblproducto
    {
        tblcaja miCaja = new tblcaja();
        historialescomision miComision = new historialescomision();
        tblhistoriales miHistorial = new tblhistoriales();

        public List<tblproducto> Existencias()
        {
            var bd = new BD();
            var lista = new List<tblproducto>();
            try
            {
                var tablaProductos = bd.tblproducto;
                foreach (var productos in tablaProductos)
                {
                    lista.Add(productos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return lista;
        }

        public void comprarProducto(string nombre, int cantidad)
        {

            try
            {
                var bd = new BD();
                var tablaProductos = bd.tblproducto;
                foreach (var productos in tablaProductos)
                {
                    if (nombre == productos.producto)
                    {

                        int saldo = miCaja.mostrarSaldo();
                        if (saldo >= (productos.precioCompra * cantidad))
                        {
                            productos.cantidad = productos.cantidad + cantidad;
                            int saldocompra = (cantidad * productos.precioCompra);
                            miCaja.Sacar(saldocompra);

                            miHistorial.historialCompra(cantidad, saldocompra, nombre);
                            MessageBox.Show("Comprar realizada.");
                        }
                        else
                        {
                            MessageBox.Show("No se pude realizar la compra por que el saldo es insuficiente.");
                        }
                    }
                }
                bd.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void venderProducto(string nombre, int cantidad)
        {


            try
            {
                var bd = new BD();
                var tablaProductos = bd.tblproducto;
                foreach (var productos in tablaProductos)
                {
                    if (nombre == productos.producto)
                    {

                        if (productos.cantidad > cantidad)
                        {
                            productos.cantidad = productos.cantidad - cantidad;
                            int saldoventa = (cantidad * productos.precioVenta);
                            miCaja.Agregar(saldoventa);
                            MessageBox.Show("Venta realizada.");
                            miComision.comisionesVendedor(saldoventa);
                            miHistorial.historialVenta(cantidad, saldoventa, nombre);

                        }
                        else if (productos.cantidad == cantidad)
                        {
                            bd.tblproducto.Remove(productos);
                            int saldoventa = (cantidad * productos.precioVenta);
                            miCaja.Agregar(saldoventa);
                            MessageBox.Show("Venta realizada.");
                            miComision.comisionesVendedor(saldoventa);
                            miHistorial.historialVenta(cantidad, saldoventa, nombre);
                        }
                        else
                        {
                            MessageBox.Show("No se pude realizar la venta por que el stock es insuficiente.");
                        }
                    }
                }
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Agregar(tblproducto ingProd)
        {
            try
            {

                var bd = new BD();
                var tablaProductos = bd.tblproducto;
                var productoExiste = false;
                foreach (var productos in tablaProductos)
                {
                    if (ingProd.producto == productos.producto)
                    {
                        productos.cantidad = productos.cantidad + ingProd.cantidad;
                        productoExiste = true;
                        MessageBox.Show("Cantidad actualizada.");
                    }
                }
                if (productoExiste == false)
                {
                    bd.tblproducto.Add(ingProd);
                    bd.SaveChanges();
                    MessageBox.Show("Producto ingresado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void Sacar(string nombre, int cantidad)
        {

            try
            {
                var bd = new BD();
                var tablaProductos = bd.tblproducto;
                foreach (var productos in tablaProductos)
                {
                    if (nombre == productos.producto)
                    {

                        if (productos.cantidad > cantidad)
                        {
                            productos.cantidad = productos.cantidad - cantidad;
                            MessageBox.Show("Producto retirado.");
                        }
                        else if (productos.cantidad == cantidad)
                        {
                            bd.tblproducto.Remove(productos);
                            MessageBox.Show("Producto retirado.");
                        }
                        else
                        {
                            MessageBox.Show("Cantidad insuficiente para sacar producto.");
                        }
                    }


                }
                bd.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public int Stock(string nombre)
        {
            int cantidad = 0;
            try
            {
                var bd = new BD();
                var tablaProductos = bd.tblproducto;
                foreach (var productos in tablaProductos)
                {
                    if (nombre == productos.producto)
                    {
                        cantidad = productos.cantidad;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return cantidad;
        }
    }

}




