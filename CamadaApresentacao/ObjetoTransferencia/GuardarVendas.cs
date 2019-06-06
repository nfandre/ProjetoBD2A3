using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class GuardarVendas
    {
        public Produto Produto { get; set; }
        public ProdutoDetalhe ProdutoDetalhe { get; set; }
        public Estoque Estoque { get; set; }
        public int Quantidade { get; set; }
        public decimal TotalProduto { get; set; }
    }
}
