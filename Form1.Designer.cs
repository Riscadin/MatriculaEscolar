namespace MatriculaEscolar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtnMatutino = new System.Windows.Forms.RadioButton();
            this.rdBtnVespertino = new System.Windows.Forms.RadioButton();
            this.rdBtnNoturno = new System.Windows.Forms.RadioButton();
            this.gpBoxTurno = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdBtnFemi = new System.Windows.Forms.RadioButton();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.txtBoxCurso = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxSobrenome = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.mskTBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskTBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mskTBoxNumCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mskTBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.mskTBoxCodigoTurma = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpBoxTurno.SuspendLayout();
            this.gpBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo da Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // rdBtnMatutino
            // 
            this.rdBtnMatutino.AutoSize = true;
            this.rdBtnMatutino.Location = new System.Drawing.Point(6, 31);
            this.rdBtnMatutino.Name = "rdBtnMatutino";
            this.rdBtnMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdBtnMatutino.TabIndex = 14;
            this.rdBtnMatutino.TabStop = true;
            this.rdBtnMatutino.Text = "Matutino";
            this.rdBtnMatutino.UseVisualStyleBackColor = true;
            this.rdBtnMatutino.CheckedChanged += new System.EventHandler(this.rdBtnMatutino_CheckedChanged);
            // 
            // rdBtnVespertino
            // 
            this.rdBtnVespertino.AutoSize = true;
            this.rdBtnVespertino.Location = new System.Drawing.Point(6, 54);
            this.rdBtnVespertino.Name = "rdBtnVespertino";
            this.rdBtnVespertino.Size = new System.Drawing.Size(75, 17);
            this.rdBtnVespertino.TabIndex = 15;
            this.rdBtnVespertino.TabStop = true;
            this.rdBtnVespertino.Text = "Vespertino";
            this.rdBtnVespertino.UseVisualStyleBackColor = true;
            this.rdBtnVespertino.CheckedChanged += new System.EventHandler(this.rdBtnVespertino_CheckedChanged);
            // 
            // rdBtnNoturno
            // 
            this.rdBtnNoturno.AutoSize = true;
            this.rdBtnNoturno.Location = new System.Drawing.Point(6, 77);
            this.rdBtnNoturno.Name = "rdBtnNoturno";
            this.rdBtnNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdBtnNoturno.TabIndex = 16;
            this.rdBtnNoturno.TabStop = true;
            this.rdBtnNoturno.Text = "Noturno";
            this.rdBtnNoturno.UseVisualStyleBackColor = true;
            this.rdBtnNoturno.CheckedChanged += new System.EventHandler(this.rdBtnNoturno_CheckedChanged);
            // 
            // gpBoxTurno
            // 
            this.gpBoxTurno.BackColor = System.Drawing.Color.White;
            this.gpBoxTurno.Controls.Add(this.rdBtnNoturno);
            this.gpBoxTurno.Controls.Add(this.rdBtnMatutino);
            this.gpBoxTurno.Controls.Add(this.rdBtnVespertino);
            this.gpBoxTurno.Location = new System.Drawing.Point(270, 340);
            this.gpBoxTurno.Name = "gpBoxTurno";
            this.gpBoxTurno.Size = new System.Drawing.Size(98, 100);
            this.gpBoxTurno.TabIndex = 13;
            this.gpBoxTurno.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sobrenome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "RG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data de nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Numero de celular";
            // 
            // gpBoxSexo
            // 
            this.gpBoxSexo.BackColor = System.Drawing.Color.White;
            this.gpBoxSexo.Controls.Add(this.rdBtnFemi);
            this.gpBoxSexo.Controls.Add(this.rdBtnMasc);
            this.gpBoxSexo.Location = new System.Drawing.Point(269, 259);
            this.gpBoxSexo.Name = "gpBoxSexo";
            this.gpBoxSexo.Size = new System.Drawing.Size(84, 59);
            this.gpBoxSexo.TabIndex = 8;
            this.gpBoxSexo.TabStop = false;
            // 
            // rdBtnFemi
            // 
            this.rdBtnFemi.AutoSize = true;
            this.rdBtnFemi.Location = new System.Drawing.Point(6, 42);
            this.rdBtnFemi.Name = "rdBtnFemi";
            this.rdBtnFemi.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFemi.TabIndex = 10;
            this.rdBtnFemi.TabStop = true;
            this.rdBtnFemi.Text = "Feminino";
            this.rdBtnFemi.UseVisualStyleBackColor = true;
            this.rdBtnFemi.CheckedChanged += new System.EventHandler(this.rdBtnFemi_CheckedChanged);
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(6, 19);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 9;
            this.rdBtnMasc.TabStop = true;
            this.rdBtnMasc.Text = "Masculino";
            this.rdBtnMasc.UseVisualStyleBackColor = true;
            this.rdBtnMasc.CheckedChanged += new System.EventHandler(this.rdBtnMasc_CheckedChanged);
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Location = new System.Drawing.Point(269, 132);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.ReadOnly = true;
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatricula.TabIndex = 15;
            // 
            // txtBoxCurso
            // 
            this.txtBoxCurso.Location = new System.Drawing.Point(269, 218);
            this.txtBoxCurso.Name = "txtBoxCurso";
            this.txtBoxCurso.Size = new System.Drawing.Size(142, 20);
            this.txtBoxCurso.TabIndex = 12;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(29, 132);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(186, 20);
            this.txtBoxNome.TabIndex = 1;
            // 
            // txtBoxSobrenome
            // 
            this.txtBoxSobrenome.Location = new System.Drawing.Point(29, 174);
            this.txtBoxSobrenome.Name = "txtBoxSobrenome";
            this.txtBoxSobrenome.Size = new System.Drawing.Size(186, 20);
            this.txtBoxSobrenome.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(29, 346);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(162, 20);
            this.txtBoxEmail.TabIndex = 6;
            // 
            // mskTBoxCpf
            // 
            this.mskTBoxCpf.Location = new System.Drawing.Point(29, 259);
            this.mskTBoxCpf.Mask = "000.000.000-00";
            this.mskTBoxCpf.Name = "mskTBoxCpf";
            this.mskTBoxCpf.Size = new System.Drawing.Size(83, 20);
            this.mskTBoxCpf.TabIndex = 4;
            // 
            // mskTBoxDataNasc
            // 
            this.mskTBoxDataNasc.Location = new System.Drawing.Point(29, 303);
            this.mskTBoxDataNasc.Mask = "00/00/0000";
            this.mskTBoxDataNasc.Name = "mskTBoxDataNasc";
            this.mskTBoxDataNasc.Size = new System.Drawing.Size(83, 20);
            this.mskTBoxDataNasc.TabIndex = 5;
            // 
            // mskTBoxNumCelular
            // 
            this.mskTBoxNumCelular.Location = new System.Drawing.Point(29, 382);
            this.mskTBoxNumCelular.Mask = "(00)000000000";
            this.mskTBoxNumCelular.Name = "mskTBoxNumCelular";
            this.mskTBoxNumCelular.Size = new System.Drawing.Size(83, 20);
            this.mskTBoxNumCelular.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(265, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Turno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(266, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Sexo";
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(74)))), ((int)(((byte)(68)))));
            this.dtGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.CodigoTurma,
            this.Curso,
            this.Turno,
            this.Nome,
            this.Sobrenome,
            this.RG,
            this.CPF,
            this.DataNascimento,
            this.Email,
            this.NumeroCelular,
            this.Sexo});
            this.dtGrid.Location = new System.Drawing.Point(441, 34);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.Size = new System.Drawing.Size(510, 504);
            this.dtGrid.TabIndex = 27;
            this.dtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellContentClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // CodigoTurma
            // 
            this.CodigoTurma.HeaderText = "CodigoTurma";
            this.CodigoTurma.Name = "CodigoTurma";
            this.CodigoTurma.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sobrenome
            // 
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NumeroCelular
            // 
            this.NumeroCelular.HeaderText = "NumeroCelular";
            this.NumeroCelular.Name = "NumeroCelular";
            this.NumeroCelular.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarUsuario.BackgroundImage")));
            this.btnAdicionarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdicionarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(264, 470);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(52, 46);
            this.btnAdicionarUsuario.TabIndex = 15;
            this.btnAdicionarUsuario.UseVisualStyleBackColor = false;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(195, 470);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 46);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mskTBoxRG
            // 
            this.mskTBoxRG.Location = new System.Drawing.Point(29, 218);
            this.mskTBoxRG.Mask = "000000000";
            this.mskTBoxRG.Name = "mskTBoxRG";
            this.mskTBoxRG.Size = new System.Drawing.Size(83, 20);
            this.mskTBoxRG.TabIndex = 3;
            // 
            // mskTBoxCodigoTurma
            // 
            this.mskTBoxCodigoTurma.Location = new System.Drawing.Point(269, 174);
            this.mskTBoxCodigoTurma.Mask = "0000";
            this.mskTBoxCodigoTurma.Name = "mskTBoxCodigoTurma";
            this.mskTBoxCodigoTurma.Size = new System.Drawing.Size(98, 20);
            this.mskTBoxCodigoTurma.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(573, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 22);
            this.label14.TabIndex = 41;
            this.label14.Text = "LISTA DE MATRÍCULA";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.BackgroundImage")));
            this.btnEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Location = new System.Drawing.Point(123, 470);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(54, 46);
            this.btnEditarUsuario.TabIndex = 16;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirUsuario.BackgroundImage")));
            this.btnExcluirUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirUsuario.FlatAppearance.BorderSize = 0;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(54, 470);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(50, 46);
            this.btnExcluirUsuario.TabIndex = 18;
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.btnEncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncerrar.BackgroundImage")));
            this.btnEncerrar.FlatAppearance.BorderSize = 0;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Location = new System.Drawing.Point(18, 3);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(47, 49);
            this.btnEncerrar.TabIndex = 19;
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Modern No. 20", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(429, 24);
            this.label20.TabIndex = 35;
            this.label20.Text = "CADASTRO DE MATRÍCULA ESCOLAR ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnMaximized);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Location = new System.Drawing.Point(957, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 550);
            this.panel1.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = "Maximizar";
            // 
            // btnMaximized
            // 
            this.btnMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMaximized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximized.BackgroundImage")));
            this.btnMaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximized.Location = new System.Drawing.Point(21, 132);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(40, 40);
            this.btnMaximized.TabIndex = 47;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Location = new System.Drawing.Point(21, 69);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 46;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "Minimizar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Sair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(56)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1040, 546);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mskTBoxCodigoTurma);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.mskTBoxRG);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdicionarUsuario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskTBoxNumCelular);
            this.Controls.Add(this.mskTBoxDataNasc);
            this.Controls.Add(this.mskTBoxCpf);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxSobrenome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxCurso);
            this.Controls.Add(this.txtBoxMatricula);
            this.Controls.Add(this.gpBoxSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpBoxTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBoxTurno.ResumeLayout(false);
            this.gpBoxTurno.PerformLayout();
            this.gpBoxSexo.ResumeLayout(false);
            this.gpBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnMatutino;
        private System.Windows.Forms.RadioButton rdBtnVespertino;
        private System.Windows.Forms.RadioButton rdBtnNoturno;
        private System.Windows.Forms.GroupBox gpBoxTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpBoxSexo;
        private System.Windows.Forms.RadioButton rdBtnFemi;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.TextBox txtBoxCurso;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxSobrenome;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.MaskedTextBox mskTBoxCpf;
        private System.Windows.Forms.MaskedTextBox mskTBoxDataNasc;
        private System.Windows.Forms.MaskedTextBox mskTBoxNumCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCelular;
        private System.Windows.Forms.MaskedTextBox mskTBoxRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.MaskedTextBox mskTBoxCodigoTurma;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnMaximized;
    }
}

