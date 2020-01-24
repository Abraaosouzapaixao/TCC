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
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
            this.Funcao();
        }

        public void Funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_funcionario> P = tb.ConsultarFuncCombo();
            cboFuncionario.DisplayMember = nameof(Database.Entity.tb_funcionario.id_funcionario);
            cboFuncionario.DataSource = P;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Business.BusinessRH bs = new Business.BusinessRH();

           // bool Idade = ObjAux.Validacoes.Idade(dtpNasc.Value);
           // if (Idade == true)
             //   throw new ArgumentException("Idade invalida");

            Database.Entity.tb_descontos des = new Database.Entity.tb_descontos();
            des.vl_inss = 0;
            des.vl_ir = Convert.ToDecimal(txtIR.Text);
            des.vl_planoodonto = Convert.ToDecimal(txtOdontologico.Text);
            des.vl_planosaude = Convert.ToDecimal(txtPlano_Saude.Text);
            des.vl_segurodevida = Convert.ToDecimal(txtSeguroVida.Text);
            des.vl_va = Convert.ToDecimal(txtVa.Text);
            des.vl_vr = Convert.ToDecimal(txtVR.Text);
            des.vl_vt = Convert.ToDecimal(txtVT.Text);

            DateTime date = Convert.ToDateTime("07/01/2019");

            Database.Entity.tb_funcionario tb = new Database.Entity.tb_funcionario();
            tb.nm_funcionario = txtNome.Text;
            tb.nm_cargo = cboCargo.Text;
            tb.nm_email = txtEmail.Text;
            tb.nm_endereco = txtEnderenco.Text;
            tb.nm_funcao = txtFuncao.Text;
            tb.rg = txtRG.Text;
            tb.cpf = txtCPF.Text;
            tb.dt_contratação = date;
            tb.dt_demissao = date;
            tb.dt_nasc = date;
            tb.vl_salario = nudSalario.Value;
            tb.vl_tel = Convert.ToInt32(txtTel.Text);
            tb.vl_fgts = Convert.ToDecimal(txtVT.Text);
            
            bs.Inserir(tb,des);




        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnderenco_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {
            Business.BusinessRH bs = new Business.BusinessRH();
            DateTime date = Convert.ToDateTime("9999-09-09");

            Database.Entity.tb_funcionario tb = new Database.Entity.tb_funcionario();
            tb.nm_funcionario = txtNome.Text;
            tb.nm_cargo = cboCargo.Text;
            tb.nm_email = txtEmail.Text;
            tb.nm_endereco = txtEnderenco.Text;
            tb.nm_funcao = txtFuncao.Text;
            tb.rg = txtRG.Text;
            tb.cpf = txtCPF.Text;
            tb.dt_contratação = dtpContracao.Value.Date;
            tb.dt_demissao = date.Date;
            tb.dt_nasc = dtpNasc.Value.Date;
            tb.vl_salario = nudSalario.Value;
            tb.vl_tel = Convert.ToInt32(txtTel.Text);
           

            
        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
