using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ObjetoTransferencia;
using CamadaDados;

namespace CamadaNegocios
{
    public class ProdutoNegocios
    {
        AcessoBancoDados acessoBancoDados = new AcessoBancoDados();
        AcessoBDMySql acessoBDMsql = new AcessoBDMySql();
        public string teste(Produto p)
        {
            try
            {
                acessoBDMsql.limparParamentros();

                acessoBDMsql.adicionarParamentros("@nomeProd", p.descricaoProduto);
                acessoBDMsql.adicionarParamentros("@imagemProd", p.imagemProduto);
                acessoBDMsql.adicionarParamentros("@codigoProd", p.imagemProduto);

                string res = acessoBDMsql.executarManipulacao(CommandType.StoredProcedure, "uspInserir").ToString();
                return res;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }
        public string ProdutoInserir (ProdutoEstoque produto,int idPessoa)
        {
            acessoBancoDados.limparParamentros();

            acessoBancoDados.adicionarParamentros("@nomeProduto", produto.Produto.descricaoProduto);
            acessoBancoDados.adicionarParamentros("@imagemProduto ", produto.Produto.imagemProduto);
            acessoBancoDados.adicionarParamentros("@codigoProduto", produto.Produto.codigoProduto);
            acessoBancoDados.adicionarParamentros("@valorProduto", produto.ProdutoDetalhe.precoProduto);
            acessoBancoDados.adicionarParamentros("@ValidadeProduto", produto.ProdutoDetalhe.validadeProduto);
            acessoBancoDados.adicionarParamentros("@Quantidade", produto.Estoque.Quantidade);
            acessoBancoDados.adicionarParamentros("@idPessoa", idPessoa);
            string idProduto = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString();

            return idProduto;
        }
        public string ProdutoAlterar (ProdutoEstoque produtoEstoque,int idPessoa)
        {
            acessoBancoDados.limparParamentros();
            
            acessoBancoDados.adicionarParamentros("@idProduto", produtoEstoque.Produto.idProduto);
            acessoBancoDados.adicionarParamentros("@nomeProduto", produtoEstoque.Produto.descricaoProduto);
            acessoBancoDados.adicionarParamentros("@imagemProduto", produtoEstoque.Produto.imagemProduto);
            acessoBancoDados.adicionarParamentros("@codigoProduto", produtoEstoque.Produto.codigoProduto);
            acessoBancoDados.adicionarParamentros("@valorProduto", produtoEstoque.ProdutoDetalhe.precoProduto);
            acessoBancoDados.adicionarParamentros("@ValidadeProduto", produtoEstoque.ProdutoDetalhe.validadeProduto);
            acessoBancoDados.adicionarParamentros("@Quantidade", produtoEstoque.Estoque.Quantidade);
            acessoBancoDados.adicionarParamentros("@idPessoa",idPessoa);

            string idProduto = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProdutoAtualizarQuantidade").ToString();

            return idProduto;
        }

        public ProdutoPesquisarColecao ConsultarProdutoCodigo(string codigoProduto)
        {
            acessoBancoDados.limparParamentros();
            ProdutoPesquisarColecao produtoColecao = new ProdutoPesquisarColecao();

            acessoBancoDados.adicionarParamentros("@codigoProduto", codigoProduto);

            DataTable dataTable = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarCodigo");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProdutoEstoque produto = new ProdutoEstoque();
                produto.Produto = new Produto();
                produto.Produto.idProduto = Convert.ToInt32(dataRow["idProduto"]);
                produto.Produto.codigoProduto = Convert.ToString(dataRow["codigoProduto"]);
                produto.Produto.descricaoProduto = Convert.ToString(dataRow["nomeProduto"]);
                produto.Produto.imagemProduto = (byte[])dataRow["imagemProduto"];
                produto.ProdutoDetalhe = new ProdutoDetalhe();
                produto.ProdutoDetalhe.precoProduto = Convert.ToDecimal(dataRow["precoProduto"]);
                produto.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(dataRow["validadeProduto"]);
                produto.Estoque = new Estoque();
                produto.Estoque.Quantidade = Convert.ToInt32(dataRow["quantidadeProduto"]);
                
                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }
        public ProdutoPesquisarColecao ConsultarProdutoID(string idProduto)
        {
            acessoBancoDados.limparParamentros();
            ProdutoPesquisarColecao produtoColecao = new ProdutoPesquisarColecao();

            acessoBancoDados.adicionarParamentros("@idProduto", idProduto);

            DataTable dataTable = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarID");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProdutoEstoque produto = new ProdutoEstoque();
                produto.Produto = new Produto();
                produto.Produto.idProduto = Convert.ToInt32(dataRow["idProduto"]);
                produto.Produto.codigoProduto = Convert.ToString(dataRow["codigoProduto"]);
                produto.Produto.descricaoProduto = Convert.ToString(dataRow["nomeProduto"]);
                produto.Produto.imagemProduto = (byte[])dataRow["imagemProduto"];
                produto.ProdutoDetalhe = new ProdutoDetalhe();
                produto.ProdutoDetalhe.precoProduto = Convert.ToDecimal(dataRow["precoProduto"]);
                produto.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(dataRow["validadeProduto"]);
                produto.Estoque = new Estoque();
                produto.Estoque.Quantidade = Convert.ToInt32(dataRow["quantidadeProduto"]);

                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }
        public ProdutoPesquisarColecao ConsultarProdutoDescricao(string descricao)
        {
            acessoBancoDados.limparParamentros();
            ProdutoPesquisarColecao produtoColecao = new ProdutoPesquisarColecao();

            acessoBancoDados.adicionarParamentros("@descricao", descricao);

            DataTable dataTable = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProdutoEstoque produto = new ProdutoEstoque();
                produto.Produto = new Produto();
                produto.Produto.idProduto = Convert.ToInt32(dataRow["idProduto"]);
                produto.Produto.codigoProduto = Convert.ToString(dataRow["codigoProduto"]);
                produto.Produto.descricaoProduto = Convert.ToString(dataRow["nomeProduto"]);
                produto.Produto.imagemProduto = (byte[])dataRow["imagemProduto"];
                produto.ProdutoDetalhe = new ProdutoDetalhe();
                produto.ProdutoDetalhe.precoProduto = Convert.ToDecimal(dataRow["precoProduto"]);
                produto.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(dataRow["validadeProduto"]);
                produto.Estoque = new Estoque();
                produto.Estoque.Quantidade = Convert.ToInt32(dataRow["quantidadeProduto"]);

                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }

        public ProdutoPesquisarColecao ConsultarDescriçãoIdCodigo(int idProduto,int codigo, string nome)
        {
            acessoBancoDados.limparParamentros();
            ProdutoPesquisarColecao produtoColecao = new ProdutoPesquisarColecao();

            acessoBancoDados.adicionarParamentros("@idProduto", idProduto);
            acessoBancoDados.adicionarParamentros("@codigoProduto", codigo);
            acessoBancoDados.adicionarParamentros("nomeProduto", nome);

            DataTable dataTable = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarCodigo");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProdutoEstoque produto = new ProdutoEstoque();
                produto.Produto = new Produto();
                produto.Produto.idProduto = Convert.ToInt32(dataRow["idProduto"]);
                produto.Produto.codigoProduto = Convert.ToString(dataRow["codigoProduto"]);
                produto.Produto.descricaoProduto = Convert.ToString(dataRow["nomeProduto"]);
                produto.Produto.imagemProduto = (byte[])dataRow["imagemProduto"];
                produto.ProdutoDetalhe = new ProdutoDetalhe();
                produto.ProdutoDetalhe.precoProduto = Convert.ToDecimal(dataRow["precoProduto"]);
                produto.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(dataRow["validadeProduto"]);
                produto.Estoque = new Estoque();
                produto.Estoque.Quantidade = Convert.ToInt32(dataRow["quantidadeProduto"]);

                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }


        public ProdutoPesquisarColecao ConsultarTodosProdutos()
        {
            acessoBancoDados.limparParamentros();

            ProdutoPesquisarColecao produtoColecao = new ProdutoPesquisarColecao();

            DataTable dataTable = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspPesquisarTodosProdutos");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProdutoEstoque produto = new ProdutoEstoque();
                produto.Produto = new Produto();
                produto.Produto.idProduto = Convert.ToInt32(dataRow["idProduto"]);
                produto.Produto.codigoProduto = Convert.ToString(dataRow["codigoProduto"]);
                produto.Produto.descricaoProduto = Convert.ToString(dataRow["nomeProduto"]);
                produto.Produto.imagemProduto = (byte[])dataRow["imagemProduto"];
                produto.ProdutoDetalhe = new ProdutoDetalhe();
                produto.ProdutoDetalhe.precoProduto = Convert.ToDecimal(dataRow["precoProduto"]);
                produto.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(dataRow["validadeProduto"]);
                produto.Estoque = new Estoque();
                produto.Estoque.Quantidade = Convert.ToInt32(dataRow["quantidadeProduto"]);
                produtoColecao.Add(produto);
            }

            return produtoColecao;
        }
        public string ProdutoExcluir(int idProduto)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idProduto",idProduto);

                string result = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();
                return result;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string VerificarExiste(string codProd)
        {
            try
            {
                acessoBancoDados.limparParamentros();

                acessoBancoDados.adicionarParamentros("@codProd", codProd);
                
                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProdutoVerificarExiste").ToString();

                return retorno;
            }
            catch (Exception  ex)
            {

               return ex.Message;
            }

        }
        public string VerificarExisteId(string codProd)
        {
            try
            {
                acessoBancoDados.limparParamentros();

                acessoBancoDados.adicionarParamentros("@codProd", codProd);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProdutoVerificarExisteId").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

    }
}
