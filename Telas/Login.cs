using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fechadenho;
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //Abraão a criptografia n tem q ficar apenas no cadastro do login.
            //Aqui é uma consulta, é só pegar os campos e mandar pra business, n precisa de uma model.
            //A business q vai comparar as infos daqui com a model ai dps abre a tela.
            //Ex:Se a senha e o nome for tal n vai poder abrir tais telas. isso tudo fica na business.
                string nome = txtNome.Text;
                string senha = txtSenha.Text;
                Bistro.menu tela = new menu();

            //Isso é para estar na business.
            //{
                if (nome == "adm" && senha == "1234")
                {
                tela.Show();
                }
            //}
                ObjAux.Criptografia Crip = new ObjAux.Criptografia();
                string crip_nome = Crip.Criptografar(nome);
                string crip_senha = Crip.Criptografar(senha);

                Database.Entity.tb_login login = new Database.Entity.tb_login();
                login.nm_senha = crip_nome;
                login.nm_usuario = crip_senha;
                

                Business.BusinessLogin bs = new Business.BusinessLogin();
                Database.Entity.tb_login tbs = bs.Consultar(login);

                if (tbs == null)
                    throw new ArgumentException("Credenciais invalidas.");

                Models.UsuarioLogado.Usuario = tbs;

                tela.Show();
         

        }

        private void lblEsquece_Click_1(object sender, EventArgs e)
        {
            Telas.RH.EsquceuSenha tela = new RH.EsquceuSenha();
            tela.Show();
        }

        private void lblCad_MouseEnter_1(object sender, EventArgs e)
        {
            lblCad.Font = new Font(lblCad.Font.Name, lblCad.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblCad_MouseLeave_1(object sender, EventArgs e)
        {
            lblCad.Font = new Font(lblCad.Font.Name, lblCad.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lblEsquece_MouseEnter_1(object sender, EventArgs e)
        {
            lblEsquece.Font = new Font(lblEsquece.Font.Name, lblEsquece.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblEsquece_MouseLeave(object sender, EventArgs e)
        {
            lblEsquece.Font = new Font(lblEsquece.Font.Name, lblEsquece.Font.SizeInPoints, FontStyle.Regular);
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

        private void lblCad_Click(object sender, EventArgs e)
        {
            Bistro.Telas.RH.CadLogin cad = new RH.CadLogin();
            cad.Show();
            this.Hide();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela para o usuário se conectar ao programa." + "É necessário um login valido. ");
        }
    }
}
