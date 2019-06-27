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
    public partial class frmPaginaInicial : Form
    {

        public frmPaginaInicial()
        {
            InitializeComponent();
           
        }

        private void frmPaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastraAluno_Click(object sender, EventArgs e)
        {
            frmConsultarAlunoFuncionario frmcadastrarAluno = null;
            if (btnCadastraAluno.Text == "Cadastro de Alunos")
            {
                frmcadastrarAluno = new frmConsultarAlunoFuncionario(TipoListagem.Aluno);
            }
            else
            {
                 frmcadastrarAluno = new frmConsultarAlunoFuncionario(TipoListagem.Professor);
            }

            frmcadastrarAluno.ShowDialog();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            pAluno.Visible = false;
            frmTimesCosultar tc = new frmTimesCosultar();
            tc.ShowDialog();
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            pAluno.Visible = true;
            btnCadastraAluno.Text = "Cadastro de Alunos";
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            pAluno.Visible = true;
            btnCadastraAluno.Text = "Cadastro de Professores";
        }
    }
}
