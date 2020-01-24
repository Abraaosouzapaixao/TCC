using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro.Telas.RH
{
    public partial class CadLogin : Form
    {
        public CadLogin()
        {
            InitializeComponent();
            //Business.BusinessLogin bs = new Business.BusinessLogin();
            //List<Database.Entity.tb_funcionario> tb = bs.Consultarfunc();
            //cboIDFunc.DataSource = tb;
            //cboIDFunc.DisplayMember = "id_funcionario";
           // cboIDFunc.ValueMember = "id_funcionario";
        }

        private void CboNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;

                ObjAux.Criptografia Crip = new ObjAux.Criptografia();
                string crip_nome = Crip.Criptografar(nome);
                string crip_senha = Crip.Criptografar(senha);
                
                Database.Entity.tb_login tb = new Database.Entity.tb_login();
                tb.id_funcionario = Convert.ToInt32(txtID.Text);
                tb.nm_senha = senha;
                tb.nm_usuario = nome;

                Business.BusinessLogin bs = new Business.BusinessLogin();
                bs.Inserir(tb);
                MessageBox.Show("Cadastro feito com sucesso");
                this.Hide();

                Telas.Login tela = new Login();
                tela.Show();
            }
            catch 
            {
                MessageBox.Show("Algum erro");
                
            }
          



        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;

            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void CadLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fechadenho;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.Abertinhu1;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.fechadenho;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastre o seu Login para ter acesso as outras funções presentes no programa.");
        }
    }
}
