using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database
{
    class DatabaseRH
    {
        Database.Entity.db_a4fdf1_basiEntities1 db = new Entity.db_a4fdf1_basiEntities1();
        public void Inserir(Entity.tb_funcionario tb, Entity.tb_descontos tbs)
        {
            db.tb_funcionario.Add(tb);
            db.SaveChanges();
            tbs.id_funcionario = tb.id_funcionario;
            db.tb_descontos.Add(tbs);
            db.SaveChanges();
        }
        public void InserirDES(Entity.tb_descontos tbb)
        {
            db.tb_descontos.Add(tbb);
            db.SaveChanges();
        }
        public void Alterar(Entity.tb_funcionario tb)
        {
            Entity.tb_funcionario Alterar = db.tb_funcionario.First(t => t.id_funcionario == tb.id_funcionario);
            Alterar.nm_funcionario = tb.nm_funcionario;
            Alterar.nm_cargo = tb.nm_cargo;
            Alterar.nm_email = tb.nm_email;
            Alterar.nm_endereco = tb.nm_endereco;
            Alterar.nm_funcao = tb.nm_funcao;
            Alterar.rg = tb.rg;
            Alterar.cpf = tb.cpf;
            Alterar.vl_salario = tb.vl_salario;
            Alterar.vl_cargahor = tb.vl_cargahor;
            Alterar.vl_tel = tb.vl_tel;
            Alterar.dt_nasc = tb.dt_nasc;
            Alterar.dt_contratação = tb.dt_contratação;
            Alterar.dt_demissao = tb.dt_demissao;
            Alterar.vl_fgts = tb.vl_fgts;
            
            db.SaveChanges();
        }
        public void Deletar(int id)
        {
            Entity.tb_funcionario tb = db.tb_funcionario.FirstOrDefault(t => t.id_funcionario == id);
            db.tb_funcionario.Remove(tb);
            db.SaveChanges();
        }
        public void InserirPonto(Entity.tb_controleponto tb)
        {
            db.tb_controleponto.Add(tb);
            db.SaveChanges();
        }
        public List<Entity.tb_controleponto> ConsultarPonto(int id)
        {
            return db.tb_controleponto.Where(t => t.id_funcionario == id).ToList();
        }
    }
}
