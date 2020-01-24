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
    public partial class FornecedorAdd : Form
    {
       
        public FornecedorAdd()
        {
           
            InitializeComponent();
            this.Funcao();
        }

        public void Funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_forncedor> Forncedor = tb.ConsultarFornCombo();
            cboConsultarFornecedor.DisplayMember = nameof(Database.Entity.tb_forncedor.nm_Fornecedor);
            cboConsultarFornecedor.DataSource = Forncedor;
            dtvConsulta.DataSource = Forncedor;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_forncedor tbs = cboConsultarFornecedor.SelectedItem as Database.Entity.tb_forncedor;
            
            Business.BusinessEstoque business = new Business.BusinessEstoque();
            List<Database.Entity.tb_forncedor> forr = business.ConsultarFornecedor(tbs);
            dtvConsulta.DataSource = forr;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FornecedorAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_forncedor tbs = new Database.Entity.tb_forncedor();
            tbs.nm_Fornecedor = txtFornecedor.Text;
            tbs.nm_endereco = txtEndereco.Text;
            tbs.nm_email = txtEmail.Text;
            tbs.nm_cidade = txtCidade.Text;
            tbs.cpf = txtCPF.Text;
            tbs.cnpj = txtCNPJ.Text;
            tbs.vl_tel =Convert.ToInt32(txtTel.Text);

            Business.BusinessEstoque bussiness = new Business.BusinessEstoque();
            bussiness.InserirForncecedor(tbs);

            Database.Entity.tb_forncedor tbss = cboConsultarFornecedor.SelectedItem as Database.Entity.tb_forncedor;

            Business.BusinessEstoque business = new Business.BusinessEstoque();
            List<Database.Entity.tb_forncedor> forr = business.ConsultarFornecedor(tbss);
            dtvConsulta.DataSource = forr;
        }

        private void DtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
