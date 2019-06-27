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
    public class ProfessorNegocios
    {
        AcessoBancoDados acessoBancoDados = new AcessoBancoDados();

        public string inserir(Professor professor)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idProfessor", professor.IdProfessor);
                acessoBancoDados.adicionarParamentros("@foto", professor.foto);
                acessoBancoDados.adicionarParamentros("@nome", professor.nome);
                acessoBancoDados.adicionarParamentros("@cpf", professor.cpf);
                acessoBancoDados.adicionarParamentros("@rg", professor.rg);
                acessoBancoDados.adicionarParamentros("@estadoCivil", professor.estadoCivil);
                acessoBancoDados.adicionarParamentros("@endereco", professor.endereco);
                acessoBancoDados.adicionarParamentros("@numero", professor.numero);
                acessoBancoDados.adicionarParamentros("@apto", professor.apto);
                acessoBancoDados.adicionarParamentros("@cep", professor.cep);
                acessoBancoDados.adicionarParamentros("@email", professor.email);
                acessoBancoDados.adicionarParamentros("@telefone", professor.telefone);
                acessoBancoDados.adicionarParamentros("@celular", professor.celular);
                acessoBancoDados.adicionarParamentros("@dataNascimento", professor.dataNascimento);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspFuncionarioInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public ProfessorColecao pesquisarTodos()
        {
            ProfessorColecao pc = new ProfessorColecao();
            acessoBancoDados.limparParamentros();

            DataTable dt = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspProfessorPesquisarTodos");
            foreach (DataRow item in dt.Rows)
            {
                Professor p = new Professor();
                p.IdProfessor = Convert.ToString(item["idProfessor"]);

                p.foto = (byte[])(item["foto"]);
                p.nome = Convert.ToString(item["nome"]);
                p.cpf = Convert.ToString(item["cpf"]);
                p.rg = Convert.ToString(item["rg"]);
                p.estadoCivil = Convert.ToString(item["estadoCivil"]);
                p.endereco = Convert.ToString(item["endereco"]);
                p.numero = Convert.ToString(item["numero"]);
                p.apto = Convert.ToString(item["apto"]);
                p.cep = Convert.ToString(item["cep"]);
                p.email = Convert.ToString(item["email"]);
                p.telefone = Convert.ToString(item["telefone"]); 
                p.celular = Convert.ToString(item["celular"]);
                p.dataNascimento = (DateTime)(item["dataNascimento"]);


                pc.Add(p);
            }
            return pc;

        }
        public string alterar(Professor professor)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@IdProfessor", professor.IdProfessor);
                acessoBancoDados.adicionarParamentros("@foto", professor.foto);
                acessoBancoDados.adicionarParamentros("@nome", professor.nome);
                acessoBancoDados.adicionarParamentros("@cpf", professor.cpf);
                acessoBancoDados.adicionarParamentros("@rg", professor.rg);
                acessoBancoDados.adicionarParamentros("@estadoCivil", professor.estadoCivil);
                acessoBancoDados.adicionarParamentros("@endereco", professor.endereco);
                acessoBancoDados.adicionarParamentros("@numero", professor.numero);
                acessoBancoDados.adicionarParamentros("@apto", professor.apto);
                acessoBancoDados.adicionarParamentros("@cep", professor.cep);
                acessoBancoDados.adicionarParamentros("@email", professor.email);
                acessoBancoDados.adicionarParamentros("@telefone", professor.telefone);
                acessoBancoDados.adicionarParamentros("@celular", professor.celular);
                acessoBancoDados.adicionarParamentros("@dataNascimento", professor.dataNascimento);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProfessorAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string excluir(string idProfessor)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idProfessor", idProfessor);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspProfessorExcluir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
