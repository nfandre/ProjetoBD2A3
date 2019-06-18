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
    public partial class frmCadastrarAluno : Form
    {
        FormularioMover fm = new FormularioMover();
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void frmCadastrarAluno_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmCadastrarResponsaveis cadastrarResponsaveis = new frmCadastrarResponsaveis();
            cadastrarResponsaveis.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void LblDtaNascimento_Click(object sender, EventArgs e)
        {

        }


        private void BtnDadosResponsaveis_Click(object sender, EventArgs e)
        {
            btnDadosResponsaveis.BackColor = Color.DarkGray;
            btnDadosPessoais.BackColor = Color.FromArgb(229, 87, 54);
            pDadosPessoais.Visible = false;
        }

        private void BtnDadosPessoais_Click(object sender, EventArgs e)
        {
            btnDadosPessoais.BackColor = Color.DarkGray;
            btnDadosResponsaveis.BackColor = Color.FromArgb(229, 87, 54);
            pDadosPessoais.Visible = true;
        }
    }
}
