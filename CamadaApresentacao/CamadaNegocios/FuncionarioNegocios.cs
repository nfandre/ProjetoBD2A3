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
    public class FuncionarioNegocios
    {
        AcessoBancoDados acessoBD = new AcessoBancoDados();

        public FuncionarioColecao verificarFuncionario(string login, string senha)
        {
            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();
            acessoBD.limparParamentros();

            acessoBD.adicionarParamentros("@login", login);
            acessoBD.adicionarParamentros("@senha", senha);

            DataTable dataTable = acessoBD.executarConsulta(System.Data.CommandType.StoredProcedure, "uspVerificarAutenticacao");

            foreach (DataRow item in dataTable.Rows)
            {
                try
                {
                    Funcionario f = new Funcionario();
                    f.idFuncionario = (int)(item["idFuncionario"]);
                    f.nome = Convert.ToString(item["nome"]);
                    f.sobreNome = Convert.ToString(item["sobrenome"]);
                    f.Cpf = Convert.ToString(item["cpf"]);
                    f.Rg = Convert.ToString(item["rg"]);
                    f.foto = (byte[])(item["foto"]);
                    f.dtaNascimento = (DateTime)(item["dtaNasc"]);
                    f.sexo = Convert.ToChar((item["sexo"]));
                    f.cargo = (string)(item["cargo"]);
                    f.login = (string)(item["loginF"]);
                    f.senha = (string)(item["senha"]);
                    f.Contato = new Contato();
                    f.Contato.celular = (string)(item["celular"]);
                    f.Contato.telefone = Convert.ToString(item["telefone"]);
                    f.Contato.email = Convert.ToString(item["email"]);
                    f.Endereco = new Endereco();
                    f.Endereco.endereco = Convert.ToString(item["Endereco"]);
                    f.Endereco.Cidade = Convert.ToString(item["Cidade"]);
                    f.Endereco.Estado = Convert.ToString(item["Estado"]);
                    f.Endereco.CEP = Convert.ToString(item["CEP"]);

                    funcionarioColecao.Add(f);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
            return funcionarioColecao;
        }

        public string verificarLoginExiste(string login)
        {
            acessoBD.limparParamentros();
            acessoBD.adicionarParamentros("@login", login);

            string result = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspFuncionarioLoginExiste").ToString();

            return result;
        }
        public string verificarLoginExisteId(string login)
        {
            acessoBD.limparParamentros();
            acessoBD.adicionarParamentros("@login", login);

            string result = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspFuncionarioLoginExisteId").ToString();

            return result;
        }

        public string FuncionarioInserir(Funcionario f)
        {
            try
            {
                acessoBD.limparParamentros();
                acessoBD.adicionarParamentros("@sexo", f.sexo);
                acessoBD.adicionarParamentros("@nomeFuncionaro", f.nome);
                acessoBD.adicionarParamentros("@sobreNomeFuncio", f.sobreNome);
                acessoBD.adicionarParamentros("@cpfFuncionario", f.Cpf);
                acessoBD.adicionarParamentros("@rgFuncionario", f.Rg);
                acessoBD.adicionarParamentros("@dtaNascFuncionario", f.dtaNascimento);
                acessoBD.adicionarParamentros("@fotoFuncionario", f.foto);
                acessoBD.adicionarParamentros("@cargoFuncionario", f.cargo);
                acessoBD.adicionarParamentros("@loginFuncionario", f.login);
                acessoBD.adicionarParamentros("@senhaFuncionario", f.senha);
                acessoBD.adicionarParamentros("@telefoneContato", f.Contato.telefone);
                acessoBD.adicionarParamentros("@celularContato", f.Contato.celular);
                acessoBD.adicionarParamentros("@emailContato", f.Contato.email);
                acessoBD.adicionarParamentros("@Endereco", f.Endereco.endereco);
                acessoBD.adicionarParamentros("@Cidade", f.Endereco.Cidade);
                acessoBD.adicionarParamentros("@Estado", f.Endereco.Estado);
                acessoBD.adicionarParamentros("@CEP", f.Endereco.CEP);

                string idPessoa = acessoBD.executarManipulacao(System.Data.CommandType.StoredProcedure, "uspFuncionarioInserir").ToString();

                return idPessoa;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }
        public FuncionarioColecao PesquisarTodosFuncionarios()
        {
            FuncionarioColecao fc = new FuncionarioColecao();
            acessoBD.limparParamentros();

            DataTable dt = acessoBD.executarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsultarTodos");

            foreach (DataRow item in dt.Rows)
            {
                Funcionario f = new Funcionario();
                f.idFuncionario = (int)(item["idFuncionario"]);
                f.nome = Convert.ToString(item["nome"]);
                f.sobreNome = Convert.ToString(item["sobrenome"]);
                f.Cpf = Convert.ToString(item["cpf"]);
                f.Rg = Convert.ToString(item["rg"]);
                f.foto = (byte[])(item["foto"]);
                f.dtaNascimento = (DateTime)(item["dtaNasc"]);
                f.sexo = Convert.ToChar(item["sexo"]);
                f.cargo = (string)(item["cargo"]);
                f.login = (string)(item["loginF"]);
                f.senha = (string)(item["senha"]);
                f.Contato = new Contato();
                f.Contato.celular = (string)(item["celular"]);
                f.Contato.telefone = Convert.ToString(item["telefone"]);
                f.Contato.email = Convert.ToString(item["email"]);
                f.Endereco = new Endereco();
                f.Endereco.endereco = Convert.ToString(item["Endereco"]);
                f.Endereco.Cidade = Convert.ToString(item["Cidade"]);
                f.Endereco.Estado = Convert.ToString(item["Estado"]);
                f.Endereco.CEP = Convert.ToString(item["CEP"]);
                fc.Add(f);
            }
            return fc;
            
        }

        public FuncionarioColecao PesquisarFuncionarioRG( string rg)
        {
            FuncionarioColecao fc = new FuncionarioColecao();
            acessoBD.limparParamentros();
            acessoBD.adicionarParamentros("rg", rg);

            DataTable dt = acessoBD.executarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsultarRG");

            foreach (DataRow item in dt.Rows)
            {
                Funcionario f = new Funcionario();
                f.idFuncionario = (int)(item["idFuncionario"]);
                f.nome = Convert.ToString(item["nome"]);
                f.sobreNome = Convert.ToString(item["sobrenome"]);
                f.Cpf = Convert.ToString(item["cpf"]);
                f.Rg = Convert.ToString(item["rg"]);
                f.foto = (byte[])(item["foto"]);
                f.dtaNascimento = (DateTime)(item["dtaNasc"]);
                f.sexo = Convert.ToChar(item["sexo"]);
                f.cargo = (string)(item["cargo"]);
                f.login = (string)(item["loginF"]);
                f.senha = (string)(item["senha"]);
                f.Contato = new Contato();
                f.Contato.celular = (string)(item["celular"]);
                f.Contato.telefone = Convert.ToString(item["telefone"]);
                f.Contato.email = Convert.ToString(item["email"]);
                f.Endereco = new Endereco();
                f.Endereco.endereco = Convert.ToString(item["Endereco"]);
                f.Endereco.Cidade = Convert.ToString(item["Cidade"]);
                f.Endereco.Estado = Convert.ToString(item["Estado"]);
                f.Endereco.CEP = Convert.ToString(item["CEP"]);
                fc.Add(f);
            }
            return fc;

        }

        public FuncionarioColecao PesquisarFuncionarioCPF(string cpf)
        {
            FuncionarioColecao fc = new FuncionarioColecao();
            acessoBD.limparParamentros();
            acessoBD.adicionarParamentros("@cpf", cpf);

            DataTable dt = acessoBD.executarConsulta(CommandType.StoredProcedure, "uspFuncionarioConsultarCPF");

            foreach (DataRow item in dt.Rows)
            {
                Funcionario f = new Funcionario();
                f.idFuncionario = (int)(item["idFuncionario"]);
                f.nome = Convert.ToString(item["nome"]);
                f.sobreNome = Convert.ToString(item["sobrenome"]);
                f.Cpf = Convert.ToString(item["cpf"]);
                f.Rg = Convert.ToString(item["rg"]);
                f.foto = (byte[])(item["foto"]);
                f.dtaNascimento = (DateTime)(item["dtaNasc"]);
                f.sexo = Convert.ToChar(item["sexo"]);
                f.cargo = (string)(item["cargo"]);
                f.login = (string)(item["loginF"]);
                f.senha = (string)(item["senha"]);
                f.Contato = new Contato();
                f.Contato.celular = (string)(item["celular"]);
                f.Contato.telefone = Convert.ToString(item["telefone"]);
                f.Contato.email = Convert.ToString(item["email"]);
                f.Endereco = new Endereco();
                f.Endereco.endereco = Convert.ToString(item["Endereco"]);
                f.Endereco.Cidade = Convert.ToString(item["Cidade"]);
                f.Endereco.Estado = Convert.ToString(item["Estado"]);
                f.Endereco.CEP = Convert.ToString(item["CEP"]);
                fc.Add(f);
            }
            return fc;

        }

        public string FuncionarioAlterar(Funcionario f)
        {
            try
            {
                acessoBD.limparParamentros();

                acessoBD.adicionarParamentros("@idFuncionario", f.idFuncionario);
                acessoBD.adicionarParamentros("@sexo", f.sexo);
                acessoBD.adicionarParamentros("@nomeFuncionaro", f.nome);
                acessoBD.adicionarParamentros("@sobreNomeFuncio", f.sobreNome);
                acessoBD.adicionarParamentros("@cpfFuncionario", f.Cpf);
                acessoBD.adicionarParamentros("@rgFuncionario", f.Rg);
                acessoBD.adicionarParamentros("@dtaNascFuncionario", f.dtaNascimento);
                acessoBD.adicionarParamentros("@fotoFuncionario", f.foto);
                acessoBD.adicionarParamentros("@loginFuncionario", f.login);
                acessoBD.adicionarParamentros("@senhaFuncionario", f.senha);
                acessoBD.adicionarParamentros("@telefoneContato", f.Contato.telefone);
                acessoBD.adicionarParamentros("@celularContato", f.Contato.celular);
                acessoBD.adicionarParamentros("@emailContato", f.Contato.email);
                acessoBD.adicionarParamentros("@Endereco", f.Endereco.endereco);
                acessoBD.adicionarParamentros("@Cidade", f.Endereco.Cidade);
                acessoBD.adicionarParamentros("@Estado", f.Endereco.Estado);
                acessoBD.adicionarParamentros("@CEP", f.Endereco.CEP);
                acessoBD.adicionarParamentros("@cargoFuncionario", f.cargo);

                string result = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspFuncionarioAtualizar").ToString();

                return result;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        
        }

        public string FuncionarioExcluir(int idFun)
        {
            try
            {
                acessoBD.limparParamentros();
                acessoBD.adicionarParamentros("@idFuncionario", idFun);

                string fun = acessoBD.executarManipulacao(CommandType.StoredProcedure, "uspFuncionarioExcluir").ToString();

                return fun;
            }
            catch (Exception ex)
            {

                return ex.Message ;
            }

        }
    }
}

