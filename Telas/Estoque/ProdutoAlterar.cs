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
    public partial class ProdutoAlterar : Form
    {
        public ProdutoAlterar()
        {
            InitializeComponent();
            this.ProdutoUD();
        }
        private void ProdutoUD()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_produto> produto = tb.ConsultarComboProduto();
            cboProduto.DisplayMember = nameof(Database.Entity.tb_produto.id_produto);
            cboProduto.DataSource = produto;
            cboID.DataSource = produto;

            dtvConsulta.DataSource = produto;


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProdutoAlterar_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto tbs = new Database.Entity.tb_produto();
            tbs.nm_produto = txtNome.Text;
            tbs.nm_categoria = cboTipoo.Text;
            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.AlterarProduto(tbs);
            List<Database.Entity.tb_produto> pro = business.Consultar(tbs);
            dtvConsulta.DataSource = pro;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_produto tbs = cboProduto.SelectedItem as Database.Entity.tb_produto;
            
            int id = Convert.ToInt32(cboProduto.Text);
            
            
            Business.BusinessEstoque business = new Business.BusinessEstoque();
            business.DeletarProduto(id);
            List<Database.Entity.tb_produto> pro = business.Consultar(tbs);
            dtvConsulta.DataSource = pro;
        }

        private void DtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
