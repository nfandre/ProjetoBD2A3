using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ProdutoEstoque
    {
        public Produto Produto { get; set; }
        public ProdutoDetalhe ProdutoDetalhe { get; set; }
        public Estoque Estoque { get; set; }
    }
}
