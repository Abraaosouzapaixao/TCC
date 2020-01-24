using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database
{
    class DatabaseCliente
    {
        Entity.db_a4fdf1_basiEntities1 db = new Entity.db_a4fdf1_basiEntities1();

        public void Inserir(Entity.tb_cliente tb)
        {
            db.tb_cliente.Add(tb);
            db.SaveChanges();
        }
        public List<Entity.tb_cliente> Consultar(int id)
        {
            List <Entity.tb_cliente> tb = db.tb_cliente.Where(t => t.id_cliente == id).ToList();
            return tb;
        }
        public void Alterar(Entity.tb_cliente tbs)
        {
            Entity.tb_cliente tb = db.tb_cliente.First(t => t.id_cliente == tbs.id_cliente);
            tb.nm_cidade = tbs.nm_cidade;
            tb.nm_email = tbs.nm_email;
            tb.nm_cliente = tbs.nm_cliente;
            tb.nm_endereco = tbs.nm_endereco;
            tb.sexo = tbs.sexo;
            tb.vl_cep = tbs.vl_cep;
            tb.vl_cpf = tb.vl_cpf;
            tb.vl_tel = tb.vl_tel;
            db.SaveChanges();
        }
        public void Deletar(int id)
        {
            Entity.tb_cliente tb = db.tb_cliente.FirstOrDefault(t => t.id_cliente == id);
            db.tb_cliente.Remove(tb);
            db.SaveChanges();
        }
    }
}
