using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string codigoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public byte[] imagemProduto { get; set; }

        public decimal calcularProduto(decimal preco)
        {
            decimal ajuda = 0;
            ajuda =  preco;
            return ajuda;
        }
        public decimal calcularTroco(decimal valorTotal, decimal valorPago)
        {
            decimal troco = valorTotal - valorPago;
            return troco;
        }
        public decimal calcularQuantidade(decimal preco,int Quantidade)
        {
            decimal ajuda = 0;
            ajuda =preco* Quantidade;
            return ajuda;
        }
    }
}
