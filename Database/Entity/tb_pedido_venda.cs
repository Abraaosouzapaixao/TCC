//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bistro.Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_pedido_venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_pedido_venda()
        {
            this.tb_pedido_venda_item = new HashSet<tb_pedido_venda_item>();
        }
    
        public int id_pedido_venda { get; set; }
        public int id_cliente { get; set; }
        public System.DateTime dt_venda { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pedido_venda_item> tb_pedido_venda_item { get; set; }
    }
}