using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using ObjetoTransferencia;
using System.Data;
namespace CamadaNegocios
{
    public class GuardarVendaNegocios
    {
        AcessoBancoDados acessoBD = new AcessoBancoDados();

        public GuardarVendaColecao GuardarVendaPesquisarProdutos()
        {
            acessoBD.limparParamentros();
            GuardarVendaColecao gVendaColecao = new GuardarVendaColecao();

            DataTable dataTable = acessoBD.executarConsulta(CommandType.StoredProcedure, "uspGuardarVendaPesquisarProdutos");

            foreach (DataRow linha in dataTable.Rows)
            {
                GuardarVendas gVenda = new GuardarVendas();

                gVenda.Produto = new Produto();
                gVenda.Produto.idProduto = (int)(linha["idProduto"]);
                gVenda.Produto.descricaoProduto = Convert.ToString(linha["nomeProduto"]);
                
                gVenda.ProdutoDetalhe = new ProdutoDetalhe();
                gVenda.ProdutoDetalhe.precoProduto = Convert.ToDecimal(linha["precoProduto"]);
                gVenda.ProdutoDetalhe.validadeProduto = Convert.ToDateTime(linha["validadeProduto"]);

                gVenda.Quantidade = Convert.ToInt32(linha["quantidadeVenda"]);
                gVenda.Estoque = new Estoque();
                gVenda.Estoque.Quantidade = Convert.ToInt32(linha["quantidadeEstoque"]);
                gVenda.TotalProduto = Convert.ToDecimal(linha["TotalProduto"]);
                gVendaColecao.Add(gVenda);
            }

            return gVendaColecao;

        }

        public string inserirGuardarVenda(GuardarVendas guardarVenda)
        {
            acessoBD.limparParamentros();
            acessoBD.adicionarParamentros("@idProduto", guardarVenda.Produto.idProduto);
            acessoBD.adicionarParamentros("@Quantidade", guardarVenda.Estoque.Quantidade);

            string retorno = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaInserir").ToString();

            return retorno;
        }

        public string AtualizarQuantidade(GuardarVendas guardarVenda,int quantAux)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@idProduto", guardarVenda.Produto.idProduto);
            acessoBD.adicionarParamentros("@Quantidade", guardarVenda.Estoque.Quantidade);
            acessoBD.adicionarParamentros("@QuantAux", quantAux);
            string idProduto = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaAtualizarQuantidade").ToString();

            return idProduto;
        }
        public string AtualizarQuantidadeProdutoRepetido(GuardarVendas guardarVenda)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@idProduto", guardarVenda.Produto.idProduto);
            acessoBD.adicionarParamentros("@Quantidade", guardarVenda.Estoque.Quantidade);

            string idProduto = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaAtualizarQuantidadeProdutoRepetido").ToString();

            return idProduto;
        }

        public string CancelarVenda(GuardarVendas guardarVenda)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@idProduto", guardarVenda.Produto.idProduto);
            string idProduto = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspCancelarVenda").ToString();

            return idProduto;
        }

        public string PesquisarPorId(int idProduto)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@idProduto", idProduto);

            string retorno = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaPesquisarPorId").ToString();

            return retorno;
        }

        public string PesquisarProdutoCodigo(string codProd)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@codigoProduto", codProd);

            string retorno = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaProdutoCodigo").ToString();

            return retorno;
        }

        public string PesquisarIdQuantidade(int IDProd)
        {
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@idProduto", IDProd);

            string retorno = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardarVendaPesquisarIdQuantidade").ToString();

            return retorno;
        }

        public string ProdutoFalta(int idProduto,int Quantidade)
        {
            try
            {
                acessoBD.limparParamentros();

                acessoBD.adicionarParamentros("@idProduto", idProduto);
                acessoBD.adicionarParamentros("@Quantidade", Quantidade);

                string result = "";
                result = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspGuardaVendaProdutoFalta").ToString();

                return result;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
