using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EstoqueRegistro
    {
        public int idEstoqueRegistro { get; set; }
        public DateTime DataHoraRegistro { get; set; }
        public char EntradaSaida { get; set; }
        public Produto Produto { get; set; }
    }
}
