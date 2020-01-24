using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Business
{
    class BusinessCombo
    {
        Database.DatabaseCombo db = new Database.DatabaseCombo();
        public List<Database.Entity.tb_produto> ConsultarComboProduto()
        {
         List<Database.Entity.tb_produto> tb = db.ConsultaCombo();
            return tb;
        }
        public List<Database.Entity.tb_forncedor> ConsultarFornCombo()
        {
            return db.ConsultarFornCombo();
        }
        public List<Database.Entity.tb_funcionario> ConsultarFuncCombo()
        {
            return db.ConsultarFuncCombo();
        }
    }
}
