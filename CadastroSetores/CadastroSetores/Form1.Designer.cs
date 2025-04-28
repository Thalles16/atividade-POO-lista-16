namespace CadastroSetores
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
            DtvSetores = new DataGridView();
            label1 = new Label();
            txtSetor = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGravar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)DtvSetores).BeginInit();
            SuspendLayout();
            // 
            // DtvSetores
            // 
            DtvSetores.AllowUserToAddRows = false;
            DtvSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtvSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtvSetores.Location = new Point(50, 81);
            DtvSetores.Name = "DtvSetores";
            DtvSetores.RowHeadersVisible = false;
            DtvSetores.RowHeadersWidth = 51;
            DtvSetores.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DtvSetores.Size = new Size(549, 203);
            DtvSetores.TabIndex = 0;
            DtvSetores.CellClick += DtvSetores_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 1;
            label1.Text = "Digite o nome do setor:";
            // 
            // txtSetor
            // 
            txtSetor.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSetor.Location = new Point(280, 39);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(195, 30);
            txtSetor.TabIndex = 2;
            txtSetor.TextChanged += txtSetor_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(151, 358);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(448, 30);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(151, 306);
            txtID.Name = "txtID";
            txtID.Size = new Size(154, 30);
            txtID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 309);
            label2.Name = "label2";
            label2.Size = new Size(31, 24);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 358);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 6;
            label3.Text = "Nome:";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(50, 409);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(104, 29);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(265, 409);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(489, 408);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 30);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListarTodos
            // 
            btnListarTodos.Location = new Point(505, 41);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(94, 29);
            btnListarTodos.TabIndex = 10;
            btnListarTodos.Text = "Todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(btnListarTodos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtNome);
            Controls.Add(txtSetor);
            Controls.Add(label1);
            Controls.Add(DtvSetores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DtvSetores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtvSetores;
        private Label label1;
        private TextBox txtSetor;
        private TextBox txtNome;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Button btnGravar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListarTodos;
    }
}
