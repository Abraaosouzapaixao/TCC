using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Business
{
    class BusinessRH
    {
        Database.DatabaseRH db = new Database.DatabaseRH();
        public void Inserir(Database.Entity.tb_funcionario tb,Database.Entity.tb_descontos tbs)
        {
            bool CPF = ObjAux.Validacoes.IsCpf(tb.cpf);
            bool Email = ObjAux.Validacoes.ValidarEmail(tb.nm_email);
            bool RG = ObjAux.Validacoes.validateRg(tb.rg);
           // DateTime date = tb.dt_nasc;
            
           // if (CPF == false)
            //    throw new ArgumentException("CPF invalido");
           // if (Email == false)
           //     throw new ArgumentException("Email invalido");
          //  if (RG == false)
           //     throw new ArgumentException("RG invalido");
          //  if (RG == false)
             //   throw new ArgumentException("RG invalido");
            db.Inserir(tb,tbs);
        }
        public void InserirDES(Database.Entity.tb_descontos tbb)
        {
            db.InserirDES(tbb);
        }
        public void Alterar(Database.Entity.tb_funcionario tb)
        {
            db.Alterar(tb);
        }
        public void Deletar(int id)
        {
            db.Deletar(id);
        }
        public void InserirPonto(Database.Entity.tb_controleponto tb)
        {
            db.InserirPonto(tb);
        }
        public List<Database.Entity.tb_controleponto> ConsultarPonto(int id)
        {
            return db.ConsultarPonto(id);
        }
    }
}
