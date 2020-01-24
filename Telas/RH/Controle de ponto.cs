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
    public partial class Controle_de_ponto : Form
    {
        public Controle_de_ponto()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Controle_de_ponto_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboFuncionarioConsulta.Text);

            Business.BusinessRH bs = new Business.BusinessRH();
            List<Database.Entity.tb_controleponto> tb = bs.ConsultarPonto(id);
            dtvConsulta.DataSource = tb;
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            Database.Entity.tb_controleponto tb = new Database.Entity.tb_controleponto();
            tb.dt_data = dtpDia.Value;
            tb.dt_entrada_almoco = dtpEntraAlmoco.Value.TimeOfDay;
            tb.dt_saida_almoco = dtpSairAlmoco.Value.TimeOfDay;
            tb.dt_entrada = dtpEntradaTrabalho.Value;
            tb.dt_saida = dtpSaidaTrabalho.Value;
            tb.vl_faltas = Convert.ToInt32(nudFaltas.Value);
            tb.id_funcionario = Convert.ToInt32(cboFuncionario.Text);
            Business.BusinessRH bs = new Business.BusinessRH();
            bs.InserirPonto(tb);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
