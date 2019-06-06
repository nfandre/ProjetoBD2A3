using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CamadaDados.Properties;
namespace CamadaDados
{
    public class AcessoBDMySql
    {
        private MySqlConnection criarConexao()
        {
            return new MySqlConnection(Settings.Default.stringConexaoMysql);
        }

        //parametro que vão para o banco de dados
        private MySqlParameterCollection mysqlParametrosColecao = new MySqlCommand().Parameters;

        //limpar parametros
        public void limparParamentros()
        {
            mysqlParametrosColecao.Clear();
        }

        public void adicionarParamentros(string nomeParametros, object valorParametros)
        {
            mysqlParametrosColecao.Add(new MySqlParameter(nomeParametros, valorParametros));
        }

        // alterar, excluir e alterar
        public object executarManipulacao(CommandType commandType, string nomeStoredProcedureouTextoSql)
        {
            try
            {
                MySqlConnection mysqlConnection = criarConexao();

                mysqlConnection.Open();

                MySqlCommand mysqlCommand = mysqlConnection.CreateCommand();

                //Colocando as coisas dentro do comando
                mysqlCommand.CommandType = commandType;
                mysqlCommand.CommandText = nomeStoredProcedureouTextoSql;

                // tempo de espera para o banco de dados ficar aberto
                mysqlCommand.CommandTimeout = 7200;

                // adicionar parametros no comando 
                foreach (MySqlParameter mysqlParameter in mysqlParametrosColecao)
                {
                    mysqlCommand.Parameters.Add(new MySqlParameter(mysqlParameter.ParameterName, mysqlParameter.Value));
                }

                //Converte arquivos do bd para o dotNet
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(mysqlCommand);

                DataTable dataTable = new DataTable();

                //Faz o comando chegar ao bd
                return mysqlCommand.ExecuteScalar();

                //Comando de busca até o bd preencher a tabela
                mysqlDataAdapter.Fill(dataTable);
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
                MySqlConnection mysqlConnection = criarConexao();

                mysqlConnection.Open();

                //Comando que leva as informações para o bd
                MySqlCommand mysqlCommand = mysqlConnection.CreateCommand();

                //Colocando os comandos dentro do sqlCommand
                mysqlCommand.CommandType = commandType;
                mysqlCommand.CommandText = nomeStoredProcedureouTextoSql;

                mysqlCommand.CommandTimeout = 7200;

                //adicionar paramentro ao comando
                foreach (MySqlParameter mysqlParameter in mysqlParametrosColecao)
                {
                    mysqlCommand.Parameters.Add(new MySqlParameter(mysqlParameter.ParameterName, mysqlParameter.Value));
                }

                //Executar comando do adaptador, converte os aquivos do bd para o dotnet
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(mysqlCommand);

                //tabela para inserir os dados do bd
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                return dataTable;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
