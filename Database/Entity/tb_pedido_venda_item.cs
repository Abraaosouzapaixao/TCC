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
    
    public partial class tb_pedido_venda_item
    {
        public int id_pedido_venda_item { get; set; }
        public int id_produto { get; set; }
        public int id_pedido_venda { get; set; }
    
        public virtual tb_pedido_venda tb_pedido_venda { get; set; }
        public virtual tb_produto tb_produto { get; set; }
    }
}