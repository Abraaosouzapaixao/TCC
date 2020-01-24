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
    public partial class FolhaDePagamento : Form
    {
        public FolhaDePagamento()
        {
            InitializeComponent();
        }
        public void Funcao()
        {
            Business.BusinessCombo tb = new Business.BusinessCombo();
            List<Database.Entity.tb_funcionario> Func = tb.ConsultarFuncCombo();
            cboFuncionario.DisplayMember = nameof(Database.Entity.tb_funcionario.nm_funcionario);
            cboFuncionario.DataSource = Func;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FolhaDePagamento_Load(object sender, EventArgs e)
        {

        }

        private void rHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_descontos funcionario = new Database.Entity.tb_descontos();
            Database.Entity.tb_funcionario Fun = cboFuncionario.SelectedItem as Database.Entity.tb_funcionario;
            Fun = cboCargo.SelectedItem as Database.Entity.tb_funcionario;
            funcionario.id_funcionario = Fun.id_funcionario; 

           


        }
    }
}
