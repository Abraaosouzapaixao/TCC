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
    public partial class AlterarFuncionario : Form
    {
        public AlterarFuncionario()
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void DtvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboFuncionario.Text);

            Business.BusinessRH bs = new Business.BusinessRH();
            bs.Deletar(id);
        }
    }
}
