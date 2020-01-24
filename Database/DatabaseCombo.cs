using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database
{
    class DatabaseCombo
    {
        Entity.db_a4fdf1_basiEntities1 db = new Entity.db_a4fdf1_basiEntities1();
        public List<Entity.tb_produto> ConsultaCombo()
        {
            List<Entity.tb_produto> tb = db.tb_produto.ToList();
            return tb;
        }
        public List<Entity.tb_forncedor> ConsultarFornCombo()
        {
           return db.tb_forncedor.ToList();
        }
        public List<Entity.tb_funcionario> ConsultarFuncCombo()
        {
            return db.tb_funcionario.ToList();
        }
        
    }
}
