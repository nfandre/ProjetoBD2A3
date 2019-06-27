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
    public partial class frmCadastroProfessor : Form
    {
        Bitmap bmpImagem;
        byte[] imagem;
        MetodosComplementares mc = new MetodosComplementares();
        Escolha escolhaSelecao;
        public frmCadastroProfessor(Escolha escolha, Professor professor)
        {
            InitializeComponent();
            escolhaSelecao = escolha;
            if (escolha.Equals(Escolha.Alterar))
            {
                txtID.ReadOnly = true;
                carregarCampos(professor);
                btnFinalizar.Text = "Atualizar";
            }
            else
            {
                txtID.ReadOnly = false;
                btnFinalizar.Text = "Finalizar";
            }
        }

        public void carregarCampos(Professor professor)
        {
            pbFoto.Image = mc.ConverterImagem(professor.foto);
            txtID.Text = professor.IdProfessor;
            txtNome.Text = professor.nome;
            txtCPF.Text = professor.cpf;
            txtRG.Text = professor.rg;
            txtEstadoCivil.Text = professor.estadoCivil;
            txtEndereco.Text = professor.endereco;
            txtNumero.Text = professor.numero.ToString();
            txtApto.Text = professor.apto;
            txtCEP.Text = professor.cep;
            txtEmail.Text = professor.email;
            txtTelefone.Text = professor.telefone;
            txtCelular.Text = professor.celular;
            txtDataNascimento.Text = professor.dataNascimento.ToString(); ;

        }

        public void adicionarCampos(Professor professor)
        {
            if (bmpImagem == null)
            {
                imagem = mc.CoverterImagemByte(pbFoto.Image);
            }
            else
            {
                imagem = mc.CoverterImagemByte(bmpImagem);
            }

            professor.IdProfessor = Convert.ToString(txtID.Text);
            professor.foto = imagem;
            professor.nome = Convert.ToString(txtNome.Text);
            professor.cpf = Convert.ToString(txtCPF.Text);
            professor.rg = Convert.ToString(txtRG.Text);
            professor.estadoCivil = Convert.ToString(txtEstadoCivil.Text);
            professor.endereco = Convert.ToString(txtEndereco.Text);
            professor.numero = Convert.ToString(txtNumero.Text);
            professor.apto = Convert.ToString(txtApto.Text);
            professor.cep = Convert.ToString(txtCEP.Text);
            professor.email = Convert.ToString(txtEmail.Text);
            professor.telefone = Convert.ToString(txtTelefone.Text);
            professor.celular = Convert.ToString(txtCelular.Text);
            professor.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ProfessorNegocios pn = new ProfessorNegocios();
            Professor professor = new Professor();

            try
            {
                adicionarCampos(professor);
                string resultado = null;
                string mensagem = null;

                if (escolhaSelecao.Equals(Escolha.Alterar))
                {
                    professor.IdProfessor = txtID.Text;
                    resultado = pn.alterar(professor);
                    mensagem = "Professor atualizado";
                }
                else
                {
                    resultado = pn.inserir(professor);
                    mensagem = "Professor cadastrado";
                }
                Convert.ToInt32(resultado);
                MessageBox.Show(mensagem + " idProfessor " + resultado);
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os campos corretamete", " Falta de dados ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            
            if (ofdSelecionarImagem.ShowDialog() == DialogResult.OK)
            {
                string nomeImagem = ofdSelecionarImagem.FileName;

                bmpImagem = new Bitmap(nomeImagem);

                pbFoto.Image = bmpImagem;
            }
        }
    }
}
