using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Business
{
    class BusinessLogin
    {
        Database.DatabaseLogin db = new Database.DatabaseLogin();
        public Database.Entity.tb_login Consultar(Database.Entity.tb_login tb)
        {
            Database.Entity.tb_login tbs = db.Consultar(tb); ;
            
                if (tb.nm_usuario == string.Empty || tb.nm_senha == string.Empty)
                    throw new Exception("Preencher todos os campos.");
                if (tb.nm_usuario != tbs.nm_usuario || tb.nm_senha != tbs.nm_senha || tbs == null)
                    throw new Exception("Usuario não cadastrado.");
                
                return tbs;
        }


        public void Inserir(Database.Entity.tb_login tb)
        {
            if (tb.nm_senha == string.Empty || tb.nm_usuario == string.Empty)
                throw new Exception("Preencha todos os campos");
            db.Inserir(tb);
        }
        public void Alterar(Database.Entity.tb_login tb)
        {
            if (tb.nm_usuario == string.Empty || tb.nm_senha == string.Empty)
                throw new ArgumentException("Preencha todos os campos");
            db.Alterar(tb);
        }
        public List<Database.Entity.tb_funcionario> ConsultarFunc()
        {
            return db.ConsultarFunc();
        }

        public Database.Entity.tb_funcionario ConsultarFuncID(Database.Entity.tb_funcionario tb)
        {
            return db.ConsultarFuncID(tb);
        }
    }
}