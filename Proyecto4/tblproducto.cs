//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto4
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblproducto
    {
        public tblproducto()
        {
            this.tblhistorialcompra = new HashSet<tblhistorialcompra>();
            this.tblhistorialventa = new HashSet<tblhistorialventa>();
        }
    
        public string producto { get; set; }
        public int precioCompra { get; set; }
        public int precioVenta { get; set; }
        public int cantidad { get; set; }
    
        public virtual ICollection<tblhistorialcompra> tblhistorialcompra { get; set; }
        public virtual ICollection<tblhistorialventa> tblhistorialventa { get; set; }
    }
}
