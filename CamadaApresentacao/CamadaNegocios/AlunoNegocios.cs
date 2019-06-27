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
    public class AlunoNegocios
    {
        AcessoBancoDados acessoBancoDados = new AcessoBancoDados();

        public string inserirAluno(Aluno aluno)
        {

            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idAluno", aluno.IdAluno);
                acessoBancoDados.adicionarParamentros("@nome", aluno.nome);
                acessoBancoDados.adicionarParamentros("@cpf", aluno.rg);
                acessoBancoDados.adicionarParamentros("@endereco", aluno.endereco);
                acessoBancoDados.adicionarParamentros("@numero", aluno.numero);
                acessoBancoDados.adicionarParamentros("@apto", aluno.apto);
                acessoBancoDados.adicionarParamentros("@email", aluno.email);
                acessoBancoDados.adicionarParamentros("@cep", aluno.cep);
                acessoBancoDados.adicionarParamentros("@telefone", aluno.telefone);
                acessoBancoDados.adicionarParamentros("@celular", aluno.celular);
                acessoBancoDados.adicionarParamentros("@dataNascimento", aluno.dataNascimento);
                acessoBancoDados.adicionarParamentros("@idCategoria", aluno.idCategoria);

                string idAluno = acessoBancoDados.executarManipulacao(System.Data.CommandType.StoredProcedure,"uspInserirAluno").ToString();
                return idAluno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
