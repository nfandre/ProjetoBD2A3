using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Funcionario
    {
        public int idFuncionario { get; set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string cargo { get; set; }
        public char sexo { get; set; }
        public byte[] foto { get; set; }
        public DateTime dtaNascimento { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
    }
}
