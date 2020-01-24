using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

          //  lblUsuario.Text = "Seja bem-vindo: " + Models.UsuarioLogado.Usuario.nm_usuario;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RH.CadastroFuncionarios telas = new Telas.RH.CadastroFuncionarios();
            telas.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para a utilização das telas selecione com o mouse uma das opções acima." + " " + "Módulos Adicionais."); 
        }

        private void cadastrarProdutoNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.Estoque tela = new Telas.Estoque.Estoque();
            tela.Show();
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.FornecedorAdd tela = new Telas.Estoque.FornecedorAdd();
            tela.Show();
        }

        private void alterarEDeletarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.FornecedorAlterar tela = new Telas.Estoque.FornecedorAlterar();
            tela.Show();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.ProdutoAdd tela = new Telas.Estoque.ProdutoAdd();
            tela.Show();
        }

        private void alterarEDeletarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.ProdutoAlterar tela = new Telas.Estoque.ProdutoAlterar();
            tela.Show();
        }

        private void alterarProdutoNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Estoque.AlterarEstoque tela = new Telas.Estoque.AlterarEstoque();
            tela.Show();
        }

        private void alterarEDeletarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RH.AlterarFuncionario telas = new Telas.RH.AlterarFuncionario();
            telas.Show();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RH.CadLogin telas = new Telas.RH.CadLogin();
            telas.Show();
        }

        private void controleDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RH.Controle_de_ponto telas = new Telas.RH.Controle_de_ponto();
            telas.Show();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.RH.FolhaDePagamento telas = new Telas.RH.FolhaDePagamento();
            telas.Show();
        }

        private void estoqueToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            estoqueToolStripMenuItem.Font = new Font(estoqueToolStripMenuItem.Font.Name, estoqueToolStripMenuItem.Font.SizeInPoints, FontStyle.Underline);
        }

        private void estoqueToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            estoqueToolStripMenuItem.Font = new Font(estoqueToolStripMenuItem.Font.Name, estoqueToolStripMenuItem.Font.SizeInPoints, FontStyle.Regular);
        }

        private void financeiroToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            financeiroToolStripMenuItem.Font = new Font(financeiroToolStripMenuItem.Font.Name, financeiroToolStripMenuItem.Font.SizeInPoints, FontStyle.Underline);
        }

        private void financeiroToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            financeiroToolStripMenuItem.Font = new Font(financeiroToolStripMenuItem.Font.Name, financeiroToolStripMenuItem.Font.SizeInPoints, FontStyle.Regular);
        }

        private void rHToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            rHToolStripMenuItem.Font = new Font(rHToolStripMenuItem.Font.Name, rHToolStripMenuItem.Font.SizeInPoints, FontStyle.Underline);
        }

        private void rHToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            rHToolStripMenuItem.Font = new Font(rHToolStripMenuItem.Font.Name,rHToolStripMenuItem.Font.SizeInPoints, FontStyle.Regular);
        }

        private void miniToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarEDeletarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cliente.AltDelCliente tela = new Telas.Cliente.AltDelCliente();
            tela.Show();
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cliente.AddCliente tela = new Telas.Cliente.AddCliente();
            tela.Show();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cliente.ConsultarCliente tela = new Telas.Cliente.ConsultarCliente();
            tela.Show();
        }
    }
}
