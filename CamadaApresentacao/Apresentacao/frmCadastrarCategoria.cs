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
    public partial class frmCadastrarCategoria : Form
    {
        Escolha EscolhaSelecao;
        public frmCadastrarCategoria(Escolha escolha, Categoria categoriaEscolhida)
        {

            InitializeComponent();
            this.EscolhaSelecao = escolha;

            if(escolha == Escolha.Cadastrar)
            {
                btnCadastrar.Text = "Cadastrar";
                lblIdCategoria.Visible = false;
                lblID.Visible = false;
            }else
            {
                btnCadastrar.Text = "Alterar";
                lblIdCategoria.Visible = true;
                lblID.Visible = true;
                carregarCampos(categoriaEscolhida);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProfessorNegociios cn = new ProfessorNegociios();
            string resultado = null; ;
            string mensagem=null;
            Categoria c = new Categoria();
            c.descricao = txtCategoria.Text;

            try
            {
                if (EscolhaSelecao == Escolha.Alterar)
                {
                    c.idCategoria = Convert.ToInt32(lblIdCategoria.Text);
                    resultado = cn.alterar(c);
                    mensagem = "Categoria atualizado: ";
                }

                if (EscolhaSelecao == Escolha.Cadastrar)
                {
                    resultado = cn.inserir(c);
                    mensagem = "Categoria cadastrada!";
                }

                Convert.ToInt32(resultado);
                MessageBox.Show(mensagem + "ID " + resultado);
                this.Hide();
            }
            catch (Exception ex)
            {

                throw ;
            }

        }
        public void carregarCampos(Categoria categoria)
        {
            txtCategoria.Text = categoria.descricao;
            
            lblIdCategoria.Text =  categoria.idCategoria.ToString();

        }
    }
}
