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
    public partial class frmInicializarPrograma : Form
    {
        public frmInicializarPrograma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tmrInicio_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                tmrInicio.Enabled = false;
                // frmLoginAcesso frmLoginAcesso = new frmLoginAcesso();

                //  frmLoginAcesso.Show();
                frmPaginaInicial frmPaginaIncial = new frmPaginaInicial();
                frmPaginaIncial.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicializarPrograma_Load(object sender, EventArgs e)
        {

        }
    }
}
