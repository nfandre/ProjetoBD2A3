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
    public class ProfessorNegociios
    {
        AcessoBancoDados acessoBancoDados = new AcessoBancoDados();

        public string inserir(Categoria categoria)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@descricao", categoria.descricao);

                string idCategoria = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspCategoriaInserir").ToString();
                return idCategoria;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public CategoriaColecao pesquisarTodos()
        {
            CategoriaColecao cc = new CategoriaColecao();
            acessoBancoDados.limparParamentros();

            DataTable dt = acessoBancoDados.executarConsulta(CommandType.StoredProcedure, "uspCategoriaPesquisarTodos");
            foreach (DataRow item in dt.Rows)
            {
                Categoria c = new Categoria();
                c.idCategoria = (int)(item["idCategoria"]);
                
                c.descricao = Convert.ToString(item["descricao"]);
                cc.Add(c);
            }
            return cc;

        }
        
        public string alterar(Categoria categoria)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idCategoria", categoria.idCategoria);
                acessoBancoDados.adicionarParamentros("@descricao", categoria.descricao);

                string idCategoria = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspCategoriaAlterar").ToString();
                return idCategoria;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string excluir(int IdCategoria)
        {
            try
            {
                acessoBancoDados.limparParamentros();
                acessoBancoDados.adicionarParamentros("@idCategoria", IdCategoria);

                string idCategoria = acessoBancoDados.executarManipulacao(CommandType.StoredProcedure, "uspCategoriaExcluir").ToString();
                return idCategoria;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
