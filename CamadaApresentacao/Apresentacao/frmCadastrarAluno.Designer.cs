namespace Apresentacao
{
    partial class frmCadastrarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAluno));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDtaNascimento = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblApto = new System.Windows.Forms.Label();
            this.txtApto = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pDadosPessoais = new System.Windows.Forms.Panel();
            this.btnDadosPessoais = new System.Windows.Forms.Button();
            this.btnDadosResponsaveis = new System.Windows.Forms.Button();
            this.pMoverTel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pDadosPessoais.SuspendLayout();
            this.pMoverTel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(-1, 12);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 24);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.LblCategoria_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Sub10";
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sub-09",
            "Sub-10",
            "Sub-11",
            "Sub-12",
            "Sub-13",
            "Sub-14",
            "Sub-15",
            "Sub-16",
            "Sub-17",
            "Sub-19"});
            this.comboBox1.Location = new System.Drawing.Point(168, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(-1, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(150, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do atleta:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(168, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 30);
            this.txtNome.TabIndex = 1;
            // 
            // lblDtaNascimento
            // 
            this.lblDtaNascimento.AutoSize = true;
            this.lblDtaNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDtaNascimento.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtaNascimento.Location = new System.Drawing.Point(2, 111);
            this.lblDtaNascimento.Name = "lblDtaNascimento";
            this.lblDtaNascimento.Size = new System.Drawing.Size(109, 24);
            this.lblDtaNascimento.TabIndex = 7;
            this.lblDtaNascimento.Text = "Data Nasc.:";
            this.lblDtaNascimento.Click += new System.EventHandler(this.LblDtaNascimento_Click);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(168, 108);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(185, 30);
            this.txtDataNascimento.TabIndex = 8;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(382, 111);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(41, 24);
            this.lblRG.TabIndex = 9;
            this.lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(443, 108);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(186, 30);
            this.txtRG.TabIndex = 10;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.BackColor = System.Drawing.Color.Transparent;
            this.lbCpf.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(651, 111);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(49, 24);
            this.lbCpf.TabIndex = 0;
            this.lbCpf.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(719, 109);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(190, 29);
            this.txtCPF.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(2, 160);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(94, 24);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(168, 157);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(461, 30);
            this.txtEndereco.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(651, 160);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(36, 24);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(719, 157);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(65, 30);
            this.txtNumero.TabIndex = 10;
            // 
            // lblApto
            // 
            this.lblApto.AutoSize = true;
            this.lblApto.BackColor = System.Drawing.Color.Transparent;
            this.lblApto.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApto.Location = new System.Drawing.Point(790, 160);
            this.lblApto.Name = "lblApto";
            this.lblApto.Size = new System.Drawing.Size(57, 24);
            this.lblApto.TabIndex = 0;
            this.lblApto.Text = "Apto:";
            // 
            // txtApto
            // 
            this.txtApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApto.Location = new System.Drawing.Point(853, 157);
            this.txtApto.Name = "txtApto";
            this.txtApto.Size = new System.Drawing.Size(104, 29);
            this.txtApto.TabIndex = 1;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(6, 211);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(49, 24);
            this.lblCEP.TabIndex = 7;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(168, 208);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(191, 30);
            this.txtCEP.TabIndex = 8;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(382, 12);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(116, 24);
            this.lblEstadoCivil.TabIndex = 9;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCivil.Location = new System.Drawing.Point(517, 9);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(183, 30);
            this.txtEstadoCivil.TabIndex = 10;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.BackColor = System.Drawing.Color.Transparent;
            this.lblProfissao.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissao.Location = new System.Drawing.Point(546, 60);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(92, 24);
            this.lblProfissao.TabIndex = 0;
            this.lblProfissao.Text = "Profissão:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfissao.Location = new System.Drawing.Point(644, 58);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(170, 29);
            this.txtProfissao.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(558, 208);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(205, 30);
            this.txtTelefone.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cel:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(558, 259);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(205, 29);
            this.txtCelular.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1099, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cadastro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(249, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 18);
            this.panel1.TabIndex = 12;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnFinalizar.Location = new System.Drawing.Point(1039, 560);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(113, 36);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnCancelar.Location = new System.Drawing.Point(285, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(279, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 3);
            this.panel3.TabIndex = 13;
            // 
            // pDadosPessoais
            // 
            this.pDadosPessoais.Controls.Add(this.txtCelular);
            this.pDadosPessoais.Controls.Add(this.label9);
            this.pDadosPessoais.Controls.Add(this.txtTelefone);
            this.pDadosPessoais.Controls.Add(this.label8);
            this.pDadosPessoais.Controls.Add(this.txtEmail);
            this.pDadosPessoais.Controls.Add(this.label7);
            this.pDadosPessoais.Controls.Add(this.txtProfissao);
            this.pDadosPessoais.Controls.Add(this.lblProfissao);
            this.pDadosPessoais.Controls.Add(this.txtEstadoCivil);
            this.pDadosPessoais.Controls.Add(this.lblEstadoCivil);
            this.pDadosPessoais.Controls.Add(this.lblCEP);
            this.pDadosPessoais.Controls.Add(this.txtApto);
            this.pDadosPessoais.Controls.Add(this.txtCEP);
            this.pDadosPessoais.Controls.Add(this.lblApto);
            this.pDadosPessoais.Controls.Add(this.txtNumero);
            this.pDadosPessoais.Controls.Add(this.lblNumero);
            this.pDadosPessoais.Controls.Add(this.txtEndereco);
            this.pDadosPessoais.Controls.Add(this.lblEndereco);
            this.pDadosPessoais.Controls.Add(this.txtCPF);
            this.pDadosPessoais.Controls.Add(this.lbCpf);
            this.pDadosPessoais.Controls.Add(this.txtRG);
            this.pDadosPessoais.Controls.Add(this.lblRG);
            this.pDadosPessoais.Controls.Add(this.txtDataNascimento);
            this.pDadosPessoais.Controls.Add(this.lblDtaNascimento);
            this.pDadosPessoais.Controls.Add(this.txtNome);
            this.pDadosPessoais.Controls.Add(this.lblNome);
            this.pDadosPessoais.Controls.Add(this.comboBox1);
            this.pDadosPessoais.Controls.Add(this.lblCategoria);
            this.pDadosPessoais.Location = new System.Drawing.Point(272, 254);
            this.pDadosPessoais.Name = "pDadosPessoais";
            this.pDadosPessoais.Size = new System.Drawing.Size(957, 342);
            this.pDadosPessoais.TabIndex = 16;
            // 
            // btnDadosPessoais
            // 
            this.btnDadosPessoais.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDadosPessoais.FlatAppearance.BorderSize = 0;
            this.btnDadosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosPessoais.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnDadosPessoais.Location = new System.Drawing.Point(285, 157);
            this.btnDadosPessoais.Name = "btnDadosPessoais";
            this.btnDadosPessoais.Size = new System.Drawing.Size(218, 36);
            this.btnDadosPessoais.TabIndex = 17;
            this.btnDadosPessoais.Text = "Dados pessoais";
            this.btnDadosPessoais.UseVisualStyleBackColor = false;
            this.btnDadosPessoais.Click += new System.EventHandler(this.BtnDadosPessoais_Click);
            // 
            // btnDadosResponsaveis
            // 
            this.btnDadosResponsaveis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.btnDadosResponsaveis.FlatAppearance.BorderSize = 0;
            this.btnDadosResponsaveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDadosResponsaveis.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosResponsaveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnDadosResponsaveis.Location = new System.Drawing.Point(515, 157);
            this.btnDadosResponsaveis.Name = "btnDadosResponsaveis";
            this.btnDadosResponsaveis.Size = new System.Drawing.Size(255, 36);
            this.btnDadosResponsaveis.TabIndex = 18;
            this.btnDadosResponsaveis.Text = "Dados dos responsáveis";
            this.btnDadosResponsaveis.UseVisualStyleBackColor = false;
            this.btnDadosResponsaveis.Click += new System.EventHandler(this.BtnDadosResponsaveis_Click);
            // 
            // pMoverTel
            // 
            this.pMoverTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(87)))), ((int)(((byte)(54)))));
            this.pMoverTel.Controls.Add(this.label1);
            this.pMoverTel.Location = new System.Drawing.Point(5, 64);
            this.pMoverTel.Name = "pMoverTel";
            this.pMoverTel.Size = new System.Drawing.Size(269, 64);
            this.pMoverTel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjetoBD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.pMoverTel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-5, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 645);
            this.panel2.TabIndex = 19;
            // 
            // frmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1271, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDadosResponsaveis);
            this.Controls.Add(this.btnDadosPessoais);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastrarAluno";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarAluno";
            this.Load += new System.EventHandler(this.frmCadastrarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pDadosPessoais.ResumeLayout(false);
            this.pDadosPessoais.PerformLayout();
            this.pMoverTel.ResumeLayout(false);
            this.pMoverTel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDtaNascimento;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblApto;
        private System.Windows.Forms.TextBox txtApto;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pDadosPessoais;
        private System.Windows.Forms.Button btnDadosPessoais;
        private System.Windows.Forms.Button btnDadosResponsaveis;
        private System.Windows.Forms.Panel pMoverTel;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}