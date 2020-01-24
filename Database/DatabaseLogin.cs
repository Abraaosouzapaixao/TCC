using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database
{
    class DatabaseLogin
    {
        Entity.db_a4fdf1_basiEntities1 db = new Entity.db_a4fdf1_basiEntities1();

        public Entity.tb_login Consultar(Entity.tb_login tb)
        {
            Entity.tb_login tbs = db.tb_login.FirstOrDefault(t => t.nm_usuario == tb.nm_usuario && t.nm_senha == tb.nm_senha);
            return tbs;
        }
        public List<Entity.tb_funcionario> ConsultarFunc()
        {
            return db.tb_funcionario.ToList();
        }
        public void Alterar(Entity.tb_login tb)
        {
            Entity.tb_login alterar = db.tb_login.First(t => t.id_funcionario == tb.id_funcionario);
            alterar.nm_senha = tb.nm_senha;
            alterar.nm_usuario = tb.nm_usuario;
            alterar.cd_confirmacao = string.Empty;
            db.SaveChanges();
        }
        public void Inserir(Entity.tb_login tb)
        {
            db.tb_login.Add(tb);
            db.SaveChanges();
        }
        public Entity.tb_funcionario ConsultarFuncID(Entity.tb_funcionario tb)
        {
            return db.tb_funcionario.FirstOrDefault(t => t.id_funcionario == tb.id_funcionario);
        }
        public void EnviarCod(Entity.tb_funcionario tb)
        {
            //Gerar Numero aletorios
            //
            Random randNum = new Random();

            //Configura o email
            //
            string Email = tb.nm_email;
            string Assunto = "Codigo de recuperação";
            string Cod = Convert.ToString(randNum.Next());
            string Messagem = ("O Codigo de Verefição é " + Cod);

            //Objeto responsavel
            //
            ObjAux.EnviarEmail enviarEmail = new ObjAux.EnviarEmail();
            enviarEmail.Enviar(Email, Assunto, Messagem);

            //Salvando o codigo no banco
            //
            Entity.tb_login alterar = db.tb_login.First(t => t.id_funcionario == tb.id_funcionario);
            alterar.cd_confirmacao = Messagem;
            db.SaveChanges();

        }

    }
}
