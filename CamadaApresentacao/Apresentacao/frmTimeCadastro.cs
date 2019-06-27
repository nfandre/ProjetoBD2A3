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
    public partial class frmTimeCadastro : Form
    {
        Escolha escolhaSelecao;
        public frmTimeCadastro(Escolha escolha, Time time)
        {
            InitializeComponent();
            escolhaSelecao = escolha;
            if(escolha == Escolha.Alterar)
            {
                txtID.Text = time.IdTime;
                txtID.ReadOnly = true; 
                txtNome.Text = time.nome;
                txtProfessorResponsavel.Text = time.professorResponsavel;
                btnCadastrar.Text = "Alterar";
            }else
            {
                txtID.ReadOnly = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            TimeNegocios tn = new TimeNegocios();
            string resultado = null; ;
            string mensagem = null;
            Time t = new Time();
            t.IdTime = txtID.Text;
            t.nome = txtNome.Text;
            t.professorResponsavel = txtProfessorResponsavel.Text;
            try
            {
                if (escolhaSelecao == Escolha.Alterar)
                {
                    t.IdTime = txtID.Text;
                    resultado = tn.alterar(t);
                    mensagem = "Time atualizado: ";
                }

                if (escolhaSelecao == Escolha.Cadastrar)
                {
                    resultado = tn.inserir(t);
                    mensagem = "Time cadastrado!";
                }

                Convert.ToInt32(resultado);
                MessageBox.Show(mensagem + " ID: " + resultado);
                this.Hide();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
