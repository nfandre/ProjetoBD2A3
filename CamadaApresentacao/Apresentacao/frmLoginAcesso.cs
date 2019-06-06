using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocios;
using ObjetoTransferencia;


namespace Apresentacao

{
    public partial class frmLoginAcesso : Form
    {
        public frmLoginAcesso()
        {
            InitializeComponent();
            
          
        }

        string result;
        private void frmLoginAcesso_Load(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FuncionarioNegocios funcionarioN = new FuncionarioNegocios();
                FuncionarioColecao funcionarioC = funcionarioN.verificarFuncionario(txtLogin.Text.Trim(), txtSenha.Text.Trim());
                result = funcionarioC[0].idFuncionario.ToString();                
                if (result != null)
                {
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario e senha inválida! ");        
            }
          
        }
    }
}
