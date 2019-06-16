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
    public partial class frmCadastrarResponsaveis : Form
    {
        FormularioMover fm = new FormularioMover();
        public frmCadastrarResponsaveis()
        {
            InitializeComponent();
        }

        private void frmCadastrarResponsaveis_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pMoverTel_MouseDown(object sender, MouseEventArgs e)
        {
            fm.MouseDown(e);
        }

        private void pMoverTel_MouseMove(object sender, MouseEventArgs e)
        {
            if (fm.MouseMover(e, this) == true)
            {
                this.SetDesktopLocation(MousePosition.X - fm.movX, MousePosition.Y - fm.movY);
            }
        }

        private void pMoverTel_MouseUp(object sender, MouseEventArgs e)
        {
            fm.MoveUp();
        }
    }
}
