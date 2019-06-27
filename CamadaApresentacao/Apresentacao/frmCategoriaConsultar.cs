using CamadaNegocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCategoriaConsultar : Form
    {
        public frmCategoriaConsultar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
         /*   dgvListar.AutoGenerateColumns = false;
            pesquisarTodasCategorias();
 
            dgvListar.Columns.Add("idCategoria", "idCategoria");
            dgvListar.Columns[0].Width = 50;
            dgvListar.Columns[0].DataPropertyName = "Categoria.idCategoria";
            dgvListar.Columns.Add("descricao", "descricao");
            dgvListar.Columns[0].Width = 50;
            dgvListar.Columns[0].DataPropertyName = "Categoria.descricao";*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        public void pesquisarTodasCategorias()
        {
            ProfessorNegociios cn = new ProfessorNegociios();
            CategoriaColecao cc = cn.pesquisarTodos();
            dgvListar.DataSource = null;
            dgvListar.DataSource = cc;
            dgvListar.Refresh();
            dgvListar.Update();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarCategoria cc = new frmCadastrarCategoria(Escolha.Cadastrar, null);

            cc.ShowDialog();
            pesquisarTodasCategorias();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                Categoria categoriaSelecionada = dgvListar.SelectedRows[0].DataBoundItem as Categoria;

                frmCadastrarCategoria cc = new frmCadastrarCategoria(Escolha.Alterar, categoriaSelecionada);

                cc.ShowDialog();
                pesquisarTodasCategorias();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count < 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Categoria categoriaSelecionda = new Categoria();
                    categoriaSelecionda = dgvListar.SelectedRows[0].DataBoundItem as Categoria;
                    ProfessorNegociios cn = new ProfessorNegociios();
                    int idCategoria = categoriaSelecionda.idCategoria;

                    string retorno = cn.excluir(idCategoria);
                    try
                    {
                        Convert.ToInt32(retorno);
                        MessageBox.Show("Categoria excluída");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("" + ex);
                    }
                    pesquisarTodasCategorias();
                }

            }
        }
    }
}
