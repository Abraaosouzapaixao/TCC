using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro.Telas.Estoque
{
    public partial class FornecedorAlterar : Form
    {
        public FornecedorAlterar()
        {
            InitializeComponent();
            this.funcao();
        }
        public void funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_forncedor> Forncedor = tb.ConsultarFornCombo();
            cboDeletarFornecedor.DisplayMember = nameof(Database.Entity.tb_forncedor.id_Forncedor);
            cboDeletarFornecedor.DataSource = Forncedor;

            dtvConsulta.DataSource = Forncedor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FornecedorAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_forncedor tbs = new Database.Entity.tb_forncedor();
            tbs.id_Forncedor = Convert.ToInt32(cboDeletarFornecedor.Text);
            int id = tbs.id_Forncedor;
            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.DeletarFornecedor(id);
            List<Database.Entity.tb_forncedor> forr = business.ConsultarFornecedor(tbs);
            dtvConsulta.DataSource = forr;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_forncedor tbs = new Database.Entity.tb_forncedor();
            tbs.id_Forncedor = Convert.ToInt32(cboID.Text);
            tbs.nm_Fornecedor = txtFornecedor.Text;
            tbs.nm_endereco = txtEndereco.Text;
            tbs.nm_email = txtEmail.Text;
            tbs.nm_cidade = txtCidade.Text;
            tbs.cpf = txtCPF.Text;
            tbs.cnpj = txtCNPJ.Text;
            tbs.vl_tel = Convert.ToInt32(txtTel.Text);
            

            Business.BusinessEstoque bussiness = new Business.BusinessEstoque();
            bussiness.AlterarFornecedor(tbs);
            Business.BusinessCombo bs = new Business.BusinessCombo();
            List<Database.Entity.tb_forncedor> forr = bs.ConsultarFornCombo();
            dtvConsulta.DataSource = forr;
        }

        private void dtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboDeletarFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
