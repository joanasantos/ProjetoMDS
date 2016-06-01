namespace ProjetoMDS
{
    partial class FormNovaConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNomeMedico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSintoma = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxObservacoesSintomas = new System.Windows.Forms.TextBox();
            this.buttonRemoverSintoma = new System.Windows.Forms.Button();
            this.listBoxSintomasPaciente = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdicionarSintoma = new System.Windows.Forms.Button();
            this.comboBoxSintomas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxObservacoesDiagnosticos = new System.Windows.Forms.TextBox();
            this.buttonRemoverDiagnosticos = new System.Windows.Forms.Button();
            this.listBoxDiagnosticosPaciente = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdicionarDiagnosticos = new System.Windows.Forms.Button();
            this.comboBoxDiagnosticos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxObservacoesMedicamentos = new System.Windows.Forms.TextBox();
            this.buttonRemoverMedicamento = new System.Windows.Forms.Button();
            this.listBoxMedicamentosPaciente = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAdicionarMedicamento = new System.Windows.Forms.Button();
            this.comboBoxMedicamentos = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.textBoxNomePaciente = new System.Windows.Forms.TextBox();
            this.textBoxIDPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSintoma.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albert Einstein Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProjetoMDS.Properties.Resources.default_user_image;
            this.pictureBox1.Location = new System.Drawing.Point(677, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelNomeMedico
            // 
            this.labelNomeMedico.AutoSize = true;
            this.labelNomeMedico.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeMedico.Location = new System.Drawing.Point(555, 16);
            this.labelNomeMedico.Name = "labelNomeMedico";
            this.labelNomeMedico.Size = new System.Drawing.Size(122, 17);
            this.labelNomeMedico.TabIndex = 2;
            this.labelNomeMedico.Text = "[Nome do Medico]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelNomeMedico);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTitulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonRegistar);
            this.groupBox2.Controls.Add(this.textBoxNomePaciente);
            this.groupBox2.Controls.Add(this.textBoxIDPaciente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 503);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSintoma);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 305);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageSintoma
            // 
            this.tabPageSintoma.Controls.Add(this.label7);
            this.tabPageSintoma.Controls.Add(this.textBoxObservacoesSintomas);
            this.tabPageSintoma.Controls.Add(this.buttonRemoverSintoma);
            this.tabPageSintoma.Controls.Add(this.listBoxSintomasPaciente);
            this.tabPageSintoma.Controls.Add(this.label6);
            this.tabPageSintoma.Controls.Add(this.buttonAdicionarSintoma);
            this.tabPageSintoma.Controls.Add(this.comboBoxSintomas);
            this.tabPageSintoma.Controls.Add(this.label2);
            this.tabPageSintoma.Location = new System.Drawing.Point(4, 22);
            this.tabPageSintoma.Name = "tabPageSintoma";
            this.tabPageSintoma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSintoma.Size = new System.Drawing.Size(731, 279);
            this.tabPageSintoma.TabIndex = 0;
            this.tabPageSintoma.Text = "Sintomas";
            this.tabPageSintoma.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(15, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Observações: ";
            // 
            // textBoxObservacoesSintomas
            // 
            this.textBoxObservacoesSintomas.Location = new System.Drawing.Point(9, 212);
            this.textBoxObservacoesSintomas.Multiline = true;
            this.textBoxObservacoesSintomas.Name = "textBoxObservacoesSintomas";
            this.textBoxObservacoesSintomas.Size = new System.Drawing.Size(716, 61);
            this.textBoxObservacoesSintomas.TabIndex = 6;
            // 
            // buttonRemoverSintoma
            // 
            this.buttonRemoverSintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRemoverSintoma.Location = new System.Drawing.Point(614, 171);
            this.buttonRemoverSintoma.Name = "buttonRemoverSintoma";
            this.buttonRemoverSintoma.Size = new System.Drawing.Size(111, 25);
            this.buttonRemoverSintoma.TabIndex = 5;
            this.buttonRemoverSintoma.Text = "Remover";
            this.buttonRemoverSintoma.UseVisualStyleBackColor = true;
            this.buttonRemoverSintoma.Click += new System.EventHandler(this.buttonRemoverSintoma_Click);
            // 
            // listBoxSintomasPaciente
            // 
            this.listBoxSintomasPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxSintomasPaciente.FormattingEnabled = true;
            this.listBoxSintomasPaciente.ItemHeight = 17;
            this.listBoxSintomasPaciente.Location = new System.Drawing.Point(305, 46);
            this.listBoxSintomasPaciente.Name = "listBoxSintomasPaciente";
            this.listBoxSintomasPaciente.Size = new System.Drawing.Size(420, 123);
            this.listBoxSintomasPaciente.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(302, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sintomas do Paciente: ";
            // 
            // buttonAdicionarSintoma
            // 
            this.buttonAdicionarSintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAdicionarSintoma.Location = new System.Drawing.Point(191, 31);
            this.buttonAdicionarSintoma.Name = "buttonAdicionarSintoma";
            this.buttonAdicionarSintoma.Size = new System.Drawing.Size(96, 25);
            this.buttonAdicionarSintoma.TabIndex = 2;
            this.buttonAdicionarSintoma.Text = "Adicionar";
            this.buttonAdicionarSintoma.UseVisualStyleBackColor = true;
            this.buttonAdicionarSintoma.Click += new System.EventHandler(this.buttonAdicionarSintoma_Click);
            // 
            // comboBoxSintomas
            // 
            this.comboBoxSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBoxSintomas.FormattingEnabled = true;
            this.comboBoxSintomas.Location = new System.Drawing.Point(18, 31);
            this.comboBoxSintomas.Name = "comboBoxSintomas";
            this.comboBoxSintomas.Size = new System.Drawing.Size(172, 25);
            this.comboBoxSintomas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Obrigatorio *";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxObservacoesDiagnosticos);
            this.tabPage1.Controls.Add(this.buttonRemoverDiagnosticos);
            this.tabPage1.Controls.Add(this.listBoxDiagnosticosPaciente);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.buttonAdicionarDiagnosticos);
            this.tabPage1.Controls.Add(this.comboBoxDiagnosticos);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 279);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Diagnosticos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(15, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observações: ";
            // 
            // textBoxObservacoesDiagnosticos
            // 
            this.textBoxObservacoesDiagnosticos.Location = new System.Drawing.Point(9, 212);
            this.textBoxObservacoesDiagnosticos.Multiline = true;
            this.textBoxObservacoesDiagnosticos.Name = "textBoxObservacoesDiagnosticos";
            this.textBoxObservacoesDiagnosticos.Size = new System.Drawing.Size(716, 61);
            this.textBoxObservacoesDiagnosticos.TabIndex = 6;
            // 
            // buttonRemoverDiagnosticos
            // 
            this.buttonRemoverDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRemoverDiagnosticos.Location = new System.Drawing.Point(614, 171);
            this.buttonRemoverDiagnosticos.Name = "buttonRemoverDiagnosticos";
            this.buttonRemoverDiagnosticos.Size = new System.Drawing.Size(111, 25);
            this.buttonRemoverDiagnosticos.TabIndex = 5;
            this.buttonRemoverDiagnosticos.Text = "Remover";
            this.buttonRemoverDiagnosticos.UseVisualStyleBackColor = true;
            this.buttonRemoverDiagnosticos.Click += new System.EventHandler(this.buttonRemoverDiagnosticos_Click);
            // 
            // listBoxDiagnosticosPaciente
            // 
            this.listBoxDiagnosticosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxDiagnosticosPaciente.FormattingEnabled = true;
            this.listBoxDiagnosticosPaciente.ItemHeight = 17;
            this.listBoxDiagnosticosPaciente.Location = new System.Drawing.Point(305, 46);
            this.listBoxDiagnosticosPaciente.Name = "listBoxDiagnosticosPaciente";
            this.listBoxDiagnosticosPaciente.Size = new System.Drawing.Size(420, 123);
            this.listBoxDiagnosticosPaciente.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(302, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Diagnosticos do Paciente: ";
            // 
            // buttonAdicionarDiagnosticos
            // 
            this.buttonAdicionarDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAdicionarDiagnosticos.Location = new System.Drawing.Point(191, 31);
            this.buttonAdicionarDiagnosticos.Name = "buttonAdicionarDiagnosticos";
            this.buttonAdicionarDiagnosticos.Size = new System.Drawing.Size(96, 25);
            this.buttonAdicionarDiagnosticos.TabIndex = 2;
            this.buttonAdicionarDiagnosticos.Text = "Adicionar";
            this.buttonAdicionarDiagnosticos.UseVisualStyleBackColor = true;
            this.buttonAdicionarDiagnosticos.Click += new System.EventHandler(this.buttonAdicionarDiagnosticos_Click);
            // 
            // comboBoxDiagnosticos
            // 
            this.comboBoxDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBoxDiagnosticos.FormattingEnabled = true;
            this.comboBoxDiagnosticos.Location = new System.Drawing.Point(18, 31);
            this.comboBoxDiagnosticos.Name = "comboBoxDiagnosticos";
            this.comboBoxDiagnosticos.Size = new System.Drawing.Size(172, 25);
            this.comboBoxDiagnosticos.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Obrigatorio *";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxObservacoesMedicamentos);
            this.tabPage2.Controls.Add(this.buttonRemoverMedicamento);
            this.tabPage2.Controls.Add(this.listBoxMedicamentosPaciente);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.buttonAdicionarMedicamento);
            this.tabPage2.Controls.Add(this.comboBoxMedicamentos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 279);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Medicamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(15, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Observações: ";
            // 
            // textBoxObservacoesMedicamentos
            // 
            this.textBoxObservacoesMedicamentos.Location = new System.Drawing.Point(9, 212);
            this.textBoxObservacoesMedicamentos.Multiline = true;
            this.textBoxObservacoesMedicamentos.Name = "textBoxObservacoesMedicamentos";
            this.textBoxObservacoesMedicamentos.Size = new System.Drawing.Size(716, 61);
            this.textBoxObservacoesMedicamentos.TabIndex = 6;
            // 
            // buttonRemoverMedicamento
            // 
            this.buttonRemoverMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRemoverMedicamento.Location = new System.Drawing.Point(614, 171);
            this.buttonRemoverMedicamento.Name = "buttonRemoverMedicamento";
            this.buttonRemoverMedicamento.Size = new System.Drawing.Size(111, 25);
            this.buttonRemoverMedicamento.TabIndex = 5;
            this.buttonRemoverMedicamento.Text = "Remover";
            this.buttonRemoverMedicamento.UseVisualStyleBackColor = true;
            this.buttonRemoverMedicamento.Click += new System.EventHandler(this.buttonRemoverMedicamento_Click);
            // 
            // listBoxMedicamentosPaciente
            // 
            this.listBoxMedicamentosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxMedicamentosPaciente.FormattingEnabled = true;
            this.listBoxMedicamentosPaciente.ItemHeight = 17;
            this.listBoxMedicamentosPaciente.Location = new System.Drawing.Point(305, 46);
            this.listBoxMedicamentosPaciente.Name = "listBoxMedicamentosPaciente";
            this.listBoxMedicamentosPaciente.Size = new System.Drawing.Size(420, 123);
            this.listBoxMedicamentosPaciente.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(302, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Medicamentos do Paciente: ";
            // 
            // buttonAdicionarMedicamento
            // 
            this.buttonAdicionarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAdicionarMedicamento.Location = new System.Drawing.Point(191, 31);
            this.buttonAdicionarMedicamento.Name = "buttonAdicionarMedicamento";
            this.buttonAdicionarMedicamento.Size = new System.Drawing.Size(96, 25);
            this.buttonAdicionarMedicamento.TabIndex = 2;
            this.buttonAdicionarMedicamento.Text = "Adicionar";
            this.buttonAdicionarMedicamento.UseVisualStyleBackColor = true;
            this.buttonAdicionarMedicamento.Click += new System.EventHandler(this.buttonAdicionarMedicamento_Click);
            // 
            // comboBoxMedicamentos
            // 
            this.comboBoxMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBoxMedicamentos.FormattingEnabled = true;
            this.comboBoxMedicamentos.Location = new System.Drawing.Point(18, 31);
            this.comboBoxMedicamentos.Name = "comboBoxMedicamentos";
            this.comboBoxMedicamentos.Size = new System.Drawing.Size(172, 25);
            this.comboBoxMedicamentos.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCancelar.Location = new System.Drawing.Point(446, 471);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 26);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRegistar.Location = new System.Drawing.Point(569, 471);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(172, 26);
            this.buttonRegistar.TabIndex = 5;
            this.buttonRegistar.Text = "Registar Consulta";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxNomePaciente
            // 
            this.textBoxNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxNomePaciente.Location = new System.Drawing.Point(158, 75);
            this.textBoxNomePaciente.Name = "textBoxNomePaciente";
            this.textBoxNomePaciente.ReadOnly = true;
            this.textBoxNomePaciente.Size = new System.Drawing.Size(346, 23);
            this.textBoxNomePaciente.TabIndex = 4;
            // 
            // textBoxIDPaciente
            // 
            this.textBoxIDPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIDPaciente.Location = new System.Drawing.Point(52, 75);
            this.textBoxIDPaciente.Name = "textBoxIDPaciente";
            this.textBoxIDPaciente.ReadOnly = true;
            this.textBoxIDPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIDPaciente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(39, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paciente: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(506, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nova Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(39, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Titulo da Consulta :";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxTitulo.Location = new System.Drawing.Point(175, 131);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(479, 23);
            this.textBoxTitulo.TabIndex = 9;
            // 
            // FormNovaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNovaConsulta";
            this.Text = "Albert Einstein Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSintoma.ResumeLayout(false);
            this.tabPageSintoma.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNomeMedico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxNomePaciente;
        private System.Windows.Forms.TextBox textBoxIDPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSintoma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxObservacoesSintomas;
        private System.Windows.Forms.Button buttonRemoverSintoma;
        private System.Windows.Forms.ListBox listBoxSintomasPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdicionarSintoma;
        private System.Windows.Forms.ComboBox comboBoxSintomas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxObservacoesDiagnosticos;
        private System.Windows.Forms.Button buttonRemoverDiagnosticos;
        private System.Windows.Forms.ListBox listBoxDiagnosticosPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdicionarDiagnosticos;
        private System.Windows.Forms.ComboBox comboBoxDiagnosticos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxObservacoesMedicamentos;
        private System.Windows.Forms.Button buttonRemoverMedicamento;
        private System.Windows.Forms.ListBox listBoxMedicamentosPaciente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAdicionarMedicamento;
        private System.Windows.Forms.ComboBox comboBoxMedicamentos;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label5;
    }
}

