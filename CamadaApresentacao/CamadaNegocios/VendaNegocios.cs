using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using CamadaDados;
using System.Data;

namespace CamadaNegocios
{
    public class VendaNegocios
    {
        AcessoBancoDados acessoBD = new AcessoBancoDados();
        AcessoBDMySql acessoBDMsql = new AcessoBDMySql();

        public string inserirVendaProduto (int idVenda,int idProduto,int idVendedor,int quantidade)
        {
            try
            {
                
                acessoBD.limparParamentros();
                acessoBD.adicionarParamentros("@idVenda", idVenda);
                acessoBD.adicionarParamentros("@idProduto", idProduto);
                acessoBD.adicionarParamentros("@idPessoa", idVenda);
                acessoBD.adicionarParamentros("@Quantidade", quantidade);
                string idVendaProduto = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspVendaDarBaixaNoEstoque").ToString();

                return idVendaProduto;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        } 
        public string inserirVenda(int idVendedor, decimal totalVenda)
        {
            try
            {
                acessoBD.limparParamentros();
                acessoBD.adicionarParamentros("@idVendedor", idVendedor);
                acessoBD.adicionarParamentros("@totalVenda", totalVenda);

               string idVenda = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspVendaInserir").ToString();

                return idVenda;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }
    }
}
