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
    public partial class frmConsultarAlunos : Form
    {
        public frmConsultarAlunos()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno cadastraAluno = new frmCadastrarAluno();
            cadastraAluno.ShowDialog();
        }
    }
}
