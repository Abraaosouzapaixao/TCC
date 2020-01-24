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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            this.Funcao();
        }
        public void Funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_forncedor> Forncedor = tb.ConsultarFornCombo();
            cboFornecedor.DisplayMember = nameof(Database.Entity.tb_forncedor.nm_Fornecedor);
            cboFornecedor.DataSource = Forncedor;

            List<Database.Entity.tb_produto> Produto = tb.ConsultarComboProduto();
            cboProduto.DisplayMember = nameof(Database.Entity.tb_produto.nm_produto);
            cboProduto.DataSource = Produto;


        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void lblEsquece_MouseEnter(object sender, EventArgs e)
        {
            lblEsquece.Font = new Font(lblEsquece.Font.Name, lblEsquece.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblEsquece_MouseLeave(object sender, EventArgs e)
        {
            lblEsquece.Font = new Font(lblEsquece.Font.Name, lblEsquece.Font.SizeInPoints, FontStyle.Regular);
        }

        private void DateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_estoque tbs = new Database.Entity.tb_estoque();
            Database.Entity.tb_produto produto = cboProduto.SelectedItem as Database.Entity.tb_produto;
            string te = cboConsultarProduto.Text;
            tbs.id_produto = produto.id_produto;
            tbs.nm_produto = cboConsultarProduto.Text;
            tbs.qnt_produto = Convert.ToInt32(nudConsultarNud.Value);
            tbs.dt_entrada = dtpConsultarEntrada.Value;
            tbs.dt_saida = dtpConsultarSaida.Value;

            Business.BusinessEstoque prod = new Business.BusinessEstoque();
            List<Database.Entity.tb_estoque> pro = prod.ConsultarEstoque(tbs);
            dtvConsulta.DataSource = pro;
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            business.InserirForneEstoque(tbs);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CboConsultarProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
