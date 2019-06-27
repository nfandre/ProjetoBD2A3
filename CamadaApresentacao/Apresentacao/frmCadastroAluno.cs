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
    public partial class frmCadastroAluno : Form
    {
        FormularioMover fm = new FormularioMover();

        public frmCadastroAluno()
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
            pDadosResponsaveis.Visible = true;
            pDadosPessoais.Visible = false;
        }

        private void BtnDadosPessoais_Click(object sender, EventArgs e)
        {
            btnDadosPessoais.BackColor = Color.DarkGray;
            btnDadosResponsaveis.BackColor = Color.FromArgb(229, 87, 54);
            pDadosPessoais.Visible = true;
            pDadosResponsaveis.Visible = false;
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();


            a.nome = txtNome.Text;
            a.rg = txtRG.Text;
            a.cpf = txtCPF.Text;
            a.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            a.email = txtEmail.Text;
            a.endereco = txtEndereco.Text;
            a.numero = txtNumero.Text;
            a.apto = txtApto.Text;
            a.telefone = txtTelefone.Text;
            a.celular = txtCelular.Text;
            a.cep = txtCEP.Text;

            AlunoNegocios alunoNegocios = new AlunoNegocios();

            
            alunoNegocios.inserirAluno(a);
            this.Hide();

        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaConsultar cc = new frmCategoriaConsultar();
            cc.ShowDialog();
        }
    }
}
