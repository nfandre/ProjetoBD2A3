using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CamadaDados.Properties;
namespace CamadaDados
{
    public class AcessoBancoDados
    {
        //Criar conexao
        private SqlConnection criarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //parametro que vão para o banco de dados
        private SqlParameterCollection sqlParametrosColecao = new SqlCommand().Parameters;

        //limpar parametros
        public void limparParamentros()
        {
            sqlParametrosColecao.Clear();
        }

        public void adicionarParamentros(string nomeParametros, object valorParametros)
        {
            sqlParametrosColecao.Add(new SqlParameter(nomeParametros, valorParametros));
        }

        // alterar, excluir e alterar
        public object executarManipulacao(CommandType commandType, string nomeStoredProcedureouTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = criarConexao();

                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouTextoSql;

                // tempo de espera para o banco de dados ficar aberto
                sqlCommand.CommandTimeout = 7200;

                // adicionar parametros no comando 
                foreach (SqlParameter sqlParameter in sqlParametrosColecao)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Converte arquivos do bd para o dotNet
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                //Faz o comando chegar ao bd
                return sqlCommand.ExecuteScalar();

                //Comando de busca até o bd preencher a tabela
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar registro no banco de dados
        public DataTable executarConsulta(CommandType commandType, string nomeStoredProcedureouTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = criarConexao();

                sqlConnection.Open();

                //Comando que leva as informações para o bd
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando os comandos dentro do sqlCommand
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouTextoSql;

                sqlCommand.CommandTimeout = 7200;

                //adicionar paramentro ao comando
                foreach (SqlParameter sqlParameter in sqlParametrosColecao)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar comando do adaptador, converte os aquivos do bd para o dotnet
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //tabela para inserir os dados do bd
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


  
    }
}
