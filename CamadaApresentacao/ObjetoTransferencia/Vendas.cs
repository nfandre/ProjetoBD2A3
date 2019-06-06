using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Vendas
    {
        public int idVenda { get; set; }
        public Produto Produto { get; set; }
        public decimal valorTotal { get; set; }
    }
}
