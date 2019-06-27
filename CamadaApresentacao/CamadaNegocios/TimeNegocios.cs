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
    public class TimeNegocios
    {
        AcessoBancoDados acessoBancoDados = new AcessoBancoDados();

        public string inserir(Time time)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idTime", time.IdTime);
                acessoBancoDados.adicionarParamentros("@nome", time.nome);
                acessoBancoDados.adicionarParamentros("@fk_Professor_idProfessor", time.professorResponsavel);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspTimeInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public TimeColecao pesquisarTodos()
        {
            TimeColecao pc = new TimeColecao();
            acessoBancoDados.limparParamentros();

            DataTable dt = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspTimeConsultar");
            foreach (DataRow item in dt.Rows)
            {
                Time t = new Time();
                t.IdTime= Convert.ToString(item["idTime"]);
                t.nome = Convert.ToString(item["nome"]);
                t.professorResponsavel = Convert.ToString(item["fk_Professor_idProfessor"]);
    
                pc.Add(t);
            }
            return pc;

        }

        public string alterar(Time time)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idTime", time.IdTime);
                acessoBancoDados.adicionarParamentros("@nome", time.nome);
                acessoBancoDados.adicionarParamentros("@fk_Professor_idProfessor", time.professorResponsavel);


                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspTimeAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string excluir(string idTime)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idTime", idTime);

                string retorno = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspTimeExcluir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
