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
    public partial class AlterarEstoque : Form
    {
        public AlterarEstoque()
        {
            InitializeComponent();
            this.funcao();
        }
        public void funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_forncedor> Forncedor = tb.ConsultarFornCombo();
            cboFornecedor.DisplayMember = nameof(Database.Entity.tb_forncedor.nm_Fornecedor);
            cboFornecedor.DataSource = Forncedor;

            List<Database.Entity.tb_produto> Produto = tb.ConsultarComboProduto();
            cboProduto.DisplayMember = nameof(Database.Entity.tb_produto.nm_produto);
            cboProduto.DataSource = Produto;
            dtvConsulta.DataSource = Produto;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_estoque tbs = new Database.Entity.tb_estoque();
            Database.Entity.tb_forncedor fornecedor = cboFornecedor.SelectedItem as Database.Entity.tb_forncedor;
            Database.Entity.tb_produto produto = cboProduto.SelectedItem as Database.Entity.tb_produto;
            tbs.id_forncedor = fornecedor.id_Forncedor;
            tbs.id_produto = produto.id_produto;

            Business.BusinessEstoque estoque = new Business.BusinessEstoque();
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_estoque tbs = new Database.Entity.tb_estoque();
            Database.Entity.tb_forncedor fornecedor = cboFornecedor.SelectedItem as Database.Entity.tb_forncedor;
            Database.Entity.tb_produto produto = cboProduto.SelectedItem as Database.Entity.tb_produto;
            tbs.id_forncedor = fornecedor.id_Forncedor;
            tbs.id_produto = produto.id_produto;
            tbs.dt_entrada = dtpEntrada.Value;
            tbs.dt_saida = dtpSaida.Value;
            tbs.qnt_produto = Convert.ToInt32(nudQTD.Value);

            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.AlterarEstoque(tbs);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
