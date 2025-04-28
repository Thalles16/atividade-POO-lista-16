namespace atividade_lista_16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExcluir = new Button();
            btnGravar = new Button();
            btnEditar = new Button();
            dgvFuncionarios = new DataGridView();
            label1 = new Label();
            lblCargo = new Label();
            label3 = new Label();
            lblData = new Label();
            lblNome = new Label();
            lbl_ID = new Label();
            lblSetor = new Label();
            label8 = new Label();
            txtSalario = new TextBox();
            txtPesquisar = new TextBox();
            txtCargo = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            cbSetor = new ComboBox();
            lblSexo = new Label();
            rbMasculino = new RadioButton();
            rbFeminino = new RadioButton();
            mtbCPF = new MaskedTextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(561, 444);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(128, 444);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(348, 444);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(29, 70);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(716, 150);
            dgvFuncionarios.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 4;
            label1.Text = "Digite o nome do funcionario";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(321, 312);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 346);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Salario";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(58, 317);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 7;
            lblData.Text = "Data";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(58, 287);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(58, 250);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 9;
            lbl_ID.Text = "ID";
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(588, 317);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(34, 15);
            lblSetor.TabIndex = 10;
            lblSetor.Text = "Setor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(588, 266);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 11;
            label8.Text = "CPF";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(101, 338);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 12;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(242, 21);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(230, 23);
            txtPesquisar.TabIndex = 13;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(365, 309);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(156, 23);
            txtCargo.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 279);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(420, 23);
            txtNome.TabIndex = 18;
            // 
            // txtID
            // 
            txtID.Location = new Point(101, 250);
            txtID.Name = "txtID";
            txtID.Size = new Size(50, 23);
            txtID.TabIndex = 19;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(103, 309);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 22;
            // 
            // cbSetor
            // 
            cbSetor.FormattingEnabled = true;
            cbSetor.Items.AddRange(new object[] { "RH", "Financeiro", "markenting", "gestao geral", "limpeza", "TI", "estagiarios", "gerentes", "outro" });
            cbSetor.Location = new Point(632, 317);
            cbSetor.Name = "cbSetor";
            cbSetor.Size = new Size(100, 23);
            cbSetor.TabIndex = 24;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(58, 396);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 25;
            lblSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(103, 394);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 28;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(189, 392);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(73, 19);
            rbFeminino.TabIndex = 29;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(632, 263);
            mtbCPF.Mask = "000.000.000-00";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(100, 23);
            mtbCPF.TabIndex = 31;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(500, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnBuscar);
            Controls.Add(mtbCPF);
            Controls.Add(rbFeminino);
            Controls.Add(rbMasculino);
            Controls.Add(lblSexo);
            Controls.Add(cbSetor);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtID);
            Controls.Add(txtNome);
            Controls.Add(txtCargo);
            Controls.Add(txtPesquisar);
            Controls.Add(txtSalario);
            Controls.Add(label8);
            Controls.Add(lblSetor);
            Controls.Add(lbl_ID);
            Controls.Add(lblNome);
            Controls.Add(lblData);
            Controls.Add(label3);
            Controls.Add(lblCargo);
            Controls.Add(label1);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Controls.Add(btnExcluir);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnGravar;
        private Button btnEditar;
        private DataGridView dgvFuncionarios;
        private Label label1;
        private Label lblCargo;
        private Label label3;
        private Label lblData;
        private Label lblNome;
        private Label lbl_ID;
        private Label lblSetor;
        private Label label8;
        private TextBox txtSalario;
        private TextBox txtPesquisar;
        private TextBox txtCargo;
        private TextBox txtNome;
        private TextBox txtID;
        private DateTimePicker dtpDataNascimento;
        private ComboBox cbSetor;
        private Label lblSexo;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private MaskedTextBox mtbCPF;
        private Button btnBuscar;
    }
}
