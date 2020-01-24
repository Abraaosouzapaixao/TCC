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
    public partial class EsquceuSenha : Form
    {
        public EsquceuSenha()
        {
            InitializeComponent();
            Business.BusinessLogin bs = new Business.BusinessLogin();
            List<Database.Entity.tb_funcionario> tbs = bs.ConsultarFunc();
            cboNmFunc.DataSource = tbs;
            cboNmFunc.DisplayMember = "id_funcionario";
            cboNmFunc.ValueMember = "id_funcionario";
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnviarCod_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario tb = new Database.Entity.tb_funcionario();
            tb.id_funcionario = Convert.ToInt32(cboNmFunc.Text);

            Business.BusinessLogin bs = new Business.BusinessLogin();
            Database.Entity.tb_funcionario func = bs.ConsultarFuncID(tb);

            Database.DatabaseLogin db = new Database.DatabaseLogin();
            db.EnviarCod(func);
        }

        private void BtnTrocar_Click(object sender, EventArgs e)
        {
            if (TxtSenha != txtConfirmar)
            {
                throw new ArgumentException("As senhas não estão corretas.");
            }
            Database.Entity.tb_login tb = new Database.Entity.tb_login();
            tb.nm_usuario = TxtUsuario.Text;
            tb.nm_senha = TxtSenha.Text;
            tb.cd_confirmacao = Convert.ToString(TxtCodigo.Text);

            Business.BusinessLogin bs = new Business.BusinessLogin();
            bs.Alterar(tb);
        }

        private void lblAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nesta tela o usuário irá selecionar o seu número para que um código seja enviado para o seu e-mail." +
                " " + "Após iserir o código a troc da senha será aceita.");
        }
    }
}
