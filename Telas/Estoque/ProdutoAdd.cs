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
    public partial class ProdutoAdd : Form
    {
        public ProdutoAdd()
        {
            InitializeComponent();
            this.Funcao();
        }
        private void Funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_produto> produto = tb.ConsultarComboProduto();
            cboNome.DisplayMember = nameof(Database.Entity.tb_produto.nm_produto);
            cboNome.DataSource = produto;


            dtvConsulta.DataSource = produto;

        }

        private void ProdutoAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItemfornecedor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto tbs = new Database.Entity.tb_produto();
            tbs.nm_produto = cboNome.Text;

            Business.BusinessEstoque produto = new Business.BusinessEstoque();
            List<Database.Entity.tb_produto> pro = produto.Consultar(tbs);
            dtvConsulta.DataSource = pro;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto tbs = new Database.Entity.tb_produto();
            tbs.nm_produto = txtNmProduto.Text;
            tbs.nm_categoria = cbotipo.Text;

            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.InserirProduto(tbs);

           

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Database.Entity.tb_produto tbs = new Database.Entity.tb_produto();
            tbs.nm_produto = txtNmProduto.Text;
            tbs.nm_categoria = cbotipo.Text;

            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.InserirProduto(tbs);

            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_produto> produto = tb.ConsultarComboProduto();


            dtvConsulta.DataSource = produto;

            Business.BusinessCombo ttb = new Business.BusinessCombo();
            List<Database.Entity.tb_produto> produtot = ttb.ConsultarComboProduto();
            cboNome.DisplayMember = nameof(Database.Entity.tb_produto.nm_produto);
            cboNome.DataSource = produto;

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
