using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto4
{
    public partial class tblcaja
    {


        public void Agregar(int plata)
        {
            try
            {
                var bd = new BD();
                var miCaja = new tblcaja();
                var caja = bd.tblcaja;
                foreach (var registro in caja)
                {
                    if (plata >= 1)
                    {
                        var monto = registro.saldo;
                        monto = monto + plata;
                        miCaja.saldo = monto;
                        bd.tblcaja.Remove(registro);
                    }
                    
                }
                bd.tblcaja.Add(miCaja);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }


        }

        public void Sacar(int plata)
        {
            try
            {
                var bd = new BD();
                var miCaja = new tblcaja();
                var caja = bd.tblcaja;
                foreach (var registro in caja)
                {
                    var monto = registro.saldo;
                    if (plata < monto)
                    {
                        monto = monto - plata;
                        miCaja.saldo = monto;
                        bd.tblcaja.Remove(registro);
                    }
                    else
                    {
                        MessageBox.Show("El monto excede el saldo disponible.");
                    }
                    
                }
                bd.tblcaja.Add(miCaja);
                bd.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        public int mostrarSaldo()
        {
            var bd = new BD();
            var caja = bd.tblcaja;
            foreach (var registro in caja)
            {
                var monto = registro.saldo;
                saldo = monto;

            }
            return saldo;
        }

    }
}
