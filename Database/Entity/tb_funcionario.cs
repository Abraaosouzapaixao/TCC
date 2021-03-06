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
    
    public partial class tb_funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_funcionario()
        {
            this.tb_controleponto = new HashSet<tb_controleponto>();
            this.tb_descontos = new HashSet<tb_descontos>();
            this.tb_despesa = new HashSet<tb_despesa>();
            this.tb_folha = new HashSet<tb_folha>();
            this.tb_login = new HashSet<tb_login>();
            this.tb_hora_extra = new HashSet<tb_hora_extra>();
        }
    
        public int id_funcionario { get; set; }
        public string nm_funcionario { get; set; }
        public string nm_email { get; set; }
        public string nm_endereco { get; set; }
        public string nm_cargo { get; set; }
        public string nm_funcao { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public System.DateTime dt_nasc { get; set; }
        public int vl_tel { get; set; }
        public decimal vl_salario { get; set; }
        public string vl_cargahor { get; set; }
        public System.DateTime dt_contratação { get; set; }
        public System.DateTime dt_demissao { get; set; }
        public decimal vl_fgts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_controleponto> tb_controleponto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_descontos> tb_descontos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_despesa> tb_despesa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_folha> tb_folha { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_login> tb_login { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_hora_extra> tb_hora_extra { get; set; }
    }
}
