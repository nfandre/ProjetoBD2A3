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
    public partial class frmTimesCosultar : Form
    {
        public frmTimesCosultar()
        {
            InitializeComponent();
            pesquisarTimes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
        public void pesquisarTimes()
        {
            TimeNegocios tn = new TimeNegocios();
            TimeColecao tc = tn.pesquisarTodos();
            dgvListar.DataSource = null;
            dgvListar.DataSource = tc;
            dgvListar.Refresh();
            dgvListar.Update();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmTimeCadastro tc = new frmTimeCadastro(Escolha.Cadastrar, null);
            tc.ShowDialog();
            pesquisarTimes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Por favor, selecione uma linha");
            }
            else
            {
                Time timeSelecionado = dgvListar.SelectedRows[0].DataBoundItem as Time;

                frmTimeCadastro cp = new frmTimeCadastro(Escolha.Alterar, timeSelecionado);

                cp.ShowDialog();
                pesquisarTimes();
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
                    Time timeSeleciondo = new Time();
                    timeSeleciondo = dgvListar.SelectedRows[0].DataBoundItem as Time;
                    TimeNegocios tc = new TimeNegocios();
                    string idTime = timeSeleciondo.IdTime;

                    string retorno = tc.excluir(idTime);
                    try
                    {
                        Convert.ToInt32(retorno);
                        MessageBox.Show("Time excluído");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("" + ex);
                    }
                    pesquisarTimes();
                }
            }
        }
    }
}
