﻿using System;
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
    public partial class frmPaginaInicial : Form
    {

        public frmPaginaInicial()
        {
            InitializeComponent();
           
        }

        private void frmPaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastraAluno_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno frmcadastrarAluno = new frmCadastrarAluno();
            frmcadastrarAluno.ShowDialog();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarAlunos consultarAlunos = new frmConsultarAlunos();
            consultarAlunos.ShowDialog();
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            pAluno.Visible = false;
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            pAluno.Visible = true;
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            pAluno.Visible = true;
        }
    }
}
