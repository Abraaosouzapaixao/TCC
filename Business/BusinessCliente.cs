using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Business
{
    class BusinessCliente
    {
        Database.DatabaseCliente db = new Database.DatabaseCliente();
        public void Inserir(Database.Entity.tb_cliente tb)
        {
            db.Inserir(tb);
        }
        public List<Database.Entity.tb_cliente> Consultar(int id)
        {
            List<Database.Entity.tb_cliente> tb = db.Consultar(id);

            return tb;
        }
        public void Alterar(Database.Entity.tb_cliente tbs)
        {
            db.Alterar(tbs);
        }
        public void Deletar(int id)
        {
            db.Deletar(id);
        }
    }
}
