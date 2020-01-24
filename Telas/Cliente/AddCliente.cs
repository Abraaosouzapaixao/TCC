using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro.Telas.Cliente
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_cliente tb = new Database.Entity.tb_cliente();
           // tb.nm_cidade = ;
            //tb.nm_cliente = ;
            //tb.nm_email =;
            //tb.nm_endereco =;
            //tb.sexo = ;
            //tb.vl_cep = Convert.ToInt32();
            //tb.vl_cpf = ;
            //tb.vl_tel = ;

            Database.DatabaseCliente db = new Database.DatabaseCliente();
            db.Inserir(tb);
        }
    }
}
