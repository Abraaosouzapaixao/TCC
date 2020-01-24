using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bistro.Database.Entity;

namespace Bistro.Business
{
    class BusinessEstoque
    {
        Database.DatabaseEstoque db = new Database.DatabaseEstoque();
        public void InserirForncecedor(Database.Entity.tb_forncedor tbs)
        {
            if (tbs.nm_Fornecedor == string.Empty || tbs.nm_endereco == string.Empty || tbs.nm_cidade == string.Empty ||
                tbs.nm_email == string.Empty || tbs.vl_tel <= 0 ||tbs.cnpj == string.Empty || tbs.cpf == string.Empty)
                throw new Exception("Invalidos");
            db.InserirForncecedor(tbs);

          
        }
        public List<Database.Entity.tb_forncedor> ConsultarFornecedor(Database.Entity.tb_forncedor tbs)
        {
            if (tbs.nm_Fornecedor == string.Empty)
                throw new Exception("Invalidos");
            return db.ConsultarFornecedor(tbs);
        }
        public void DeletarFornecedor(int id)
        {
               db.DeletarFornecedor(id);
        }
        public void AlterarFornecedor(Database.Entity.tb_forncedor tbs)
        {
            if (tbs.nm_Fornecedor == string.Empty || tbs.nm_endereco == string.Empty || tbs.nm_cidade == string.Empty ||
                tbs.nm_email == string.Empty || tbs.vl_tel <= 0 || tbs.cnpj == string.Empty || tbs.cpf == string.Empty)
                throw new Exception("Invalidos");
            db.AlterarFornecedor(tbs);
        }

       

        //produto


        public void InserirProduto(Database.Entity.tb_produto tbs)
        {
            if (tbs.nm_produto == string.Empty || tbs.nm_marca == string.Empty ||
                tbs.nm_lote == string.Empty )
                throw new Exception("Invalidos");
            db.InserirProduto(tbs);
        }

        public List<Database.Entity.tb_produto> Consultar(Database.Entity.tb_produto tbs)
        {
            if (tbs.nm_produto == string.Empty || tbs.nm_marca == string.Empty )
                throw new Exception("Invalidos");
            return db.Consultar(tbs);
        }
        public void AlterarProduto(Database.Entity.tb_produto tbs)
        {
            if (tbs.nm_produto == string.Empty || tbs.nm_marca == string.Empty ||
                tbs.nm_lote == string.Empty)
                throw new Exception("Invalidos");
            db.AlterarProduto(tbs);
        }
        public void DeletarProduto(int id)
        {
            
            db.DeletarProduto(id);
        }

        //estoque


        public List<Database.Entity.tb_estoque> ConsultarEstoque(Database.Entity.tb_estoque tbs)
        {
            return db.ConsultarEstoque(tbs);
        }

        public void InserirForneEstoque(Database.Entity.tb_estoque tb)
        {
          db.InserirForneEstoque(tb);
        }

        public void AlterarEstoque(Database.Entity.tb_estoque tbs)
        {
            

        }
    }
}
