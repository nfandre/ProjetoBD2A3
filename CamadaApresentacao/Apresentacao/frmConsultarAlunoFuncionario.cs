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
    public partial class frmConsultarAlunoFuncionario : Form
    {
        TipoListagem tipoListagemSelecao;
        MetodosComplementares mc = new MetodosComplementares();
        public frmConsultarAlunoFuncionario(TipoListagem tipoListagem)
        {
            InitializeComponent();
            dgvListar.ReadOnly = true;
            this.tipoListagemSelecao = tipoListagem;
            //  dgvListar.AutoGenerateColumns = false;
            if (tipoListagem == TipoListagem.Professor)
            {
                pesquisarTodosProfessores();
                //adicionando os dados as DataGridView
                /*  dgvListar.Columns.Add("idProfessor", "id  ");
                  dgvListar.Columns[0].DataPropertyName = "Professor.idProfessor";
                  dgvListar.Columns[0].Width = 50;
                  dgvListar.Columns.Add("nome", "nome");
                  dgvListar.Columns[1].DataPropertyName = "Professor.nome";
                  dgvListar.Columns[1].Width = 152;
                  dgvListar.Columns.Add("cpf", "cpf");
                  dgvListar.Columns[2].DataPropertyName = "Professor.cpf";
                  dgvListar.Columns.Add("rg", "RG");
                  dgvListar.Columns[3].DataPropertyName = "Professor.rg";
                  dgvListar.Columns.Add("dataNascimento", "dtaNascimento");
                  dgvListar.Columns[4].DataPropertyName = "Professor.dataNascimento";*/

            }
        }
        public void pesquisarTodosProfessores()
        {
            ProfessorNegocios pn = new ProfessorNegocios();
            ProfessorColecao pc = pn.pesquisarTodos();
            dgvListar.DataSource = null;
            dgvListar.DataSource = pc;
            dgvListar.Columns[1].Visible = false;
            dgvListar.Refresh();
            dgvListar.Update();


        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tipoListagemSelecao == TipoListagem.Aluno)
            {
                frmCadastroAluno ca = new frmCadastroAluno();
                ca.ShowDialog();
            }
            else
            {
                frmCadastroProfessor cp = new frmCadastroProfessor(Escolha.Cadastrar, null);
                cp.ShowDialog();

            }
            pesquisarTodosProfessores();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                Professor professorSelecionado = dgvListar.SelectedRows[0].DataBoundItem as Professor;

                frmCadastroProfessor cp = new frmCadastroProfessor(Escolha.Alterar, professorSelecionado);

                cp.ShowDialog();
                pesquisarTodosProfessores();
            }
        }

        private void dgvListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (tipoListagemSelecao == TipoListagem.Professor)
            {
                Professor professorSelecionado = dgvListar.SelectedRows[0].DataBoundItem as Professor;
                pbFoto.Image = mc.ConverterImagem(professorSelecionado.foto);
            }
            else
            {
                Aluno alunoSelecionado = dgvListar.SelectedRows[0].DataBoundItem as Aluno;
                //ptbImagem.Image = mc.ConverterImagem(alunoSelecionado);
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
                    Professor professorSelecionda = new Professor();
                    professorSelecionda = dgvListar.SelectedRows[0].DataBoundItem as Professor;
                    ProfessorNegocios pn = new ProfessorNegocios();
                    string idProfessor = professorSelecionda.IdProfessor;

                    string retorno = pn.excluir(idProfessor);
                    try
                    {
                        Convert.ToInt32(retorno);
                        MessageBox.Show("Professor excluído");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("" + ex);
                    }
                    pesquisarTodosProfessores();
                }
            }
        }
    }
}