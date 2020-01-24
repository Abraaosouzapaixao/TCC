using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.Database
{
    class DatabaseEstoque
    {
        Entity.db_a4fdf1_basiEntities1 db = new Entity.db_a4fdf1_basiEntities1();



        //Fornecedor
        public void InserirForncecedor(Entity.tb_forncedor tbs)
        {
            db.tb_forncedor.Add(tbs);
            db.SaveChanges();
        }
        public List<Entity.tb_forncedor> ConsultarFornecedor(Entity.tb_forncedor tbs)
        {
            List<Entity.tb_forncedor> tb = db.tb_forncedor.Where(t => t.nm_Fornecedor == tbs.nm_Fornecedor).ToList();
            return tb;
        }
        public void DeletarFornecedor(int id)
        {
            Entity.tb_forncedor tb = db.tb_forncedor.First(t => t.id_Forncedor == id);
            db.tb_forncedor.Remove(tb);
            db.SaveChanges();
        }
        public void AlterarFornecedor(Entity.tb_forncedor fornecedor)
        {
            Entity.tb_forncedor alterar = db.tb_forncedor.First(t => t.id_Forncedor == fornecedor.id_Forncedor);
            alterar.nm_Fornecedor = fornecedor.nm_Fornecedor;
            alterar.nm_endereco = fornecedor.nm_endereco;
            alterar.nm_cidade = fornecedor.nm_cidade;
            alterar.nm_email = fornecedor.nm_email;
            alterar.vl_tel = fornecedor.vl_tel;
            alterar.cnpj = fornecedor.cnpj;
            alterar.cpf = fornecedor.cpf;
            db.SaveChanges();
        }


        //Produto
        public void InserirProduto(Entity.tb_produto produto)
        {
            db.tb_produto.Add(produto);
            db.SaveChanges();
        }
        public List<Entity.tb_produto> Consultar(Entity.tb_produto tbs)
        {
            List<Entity.tb_produto> tb = db.tb_produto.Where(t => t.nm_produto.Contains(tbs.nm_produto) || t.nm_marca == tbs.nm_marca ||
                                                             t.vl_preco == tbs.vl_preco || t.dt_validade == tbs.dt_validade)
                                                    .ToList();
            return tb;
        }
        public void AlterarProduto(Entity.tb_produto tbs)
        {
            Entity.tb_produto alterar = db.tb_produto.First(t => t.id_produto == tbs.id_produto);
            alterar.nm_lote = tbs.nm_lote;
            alterar.nm_produto = tbs.nm_produto;
            alterar.nm_marca = tbs.nm_marca;
            alterar.vl_preco = tbs.vl_preco;
            alterar.dt_validade = tbs.dt_validade;
            db.SaveChanges();

        }
        public void DeletarProduto(int id)
        {
            Entity.tb_produto tbs = db.tb_produto.FirstOrDefault(t => t.id_produto == id);
            db.tb_produto.Remove(tbs);
            db.SaveChanges();
        }



        //estoque

        public List<Entity.tb_estoque> ConsultarEstoque(Entity.tb_estoque tbs)
        {
            List<Entity.tb_estoque> tb =
                db.tb_estoque.Where(t => t.qnt_produto == tbs.qnt_produto && t.dt_entrada == tbs.dt_entrada
                && t.dt_saida == tbs.dt_saida).ToList();

            return tb;
        }

        public void InserirForneEstoque(Entity.tb_estoque tb)
        {
            db.tb_estoque.Add(tb);
            db.SaveChanges();

        }

        public void AlterarEstoque(Entity.tb_estoque tbs)
        {
            Entity.tb_estoque alterar = db.tb_estoque.First(t => t.id_forncedor == tbs.id_forncedor);
            alterar.id_produto = tbs.id_produto;
            alterar.qnt_produto = tbs.qnt_produto;
            alterar.dt_entrada = tbs.dt_entrada;
            alterar.dt_saida = tbs.dt_saida;
            db.SaveChanges();

        }
    }
}



     
