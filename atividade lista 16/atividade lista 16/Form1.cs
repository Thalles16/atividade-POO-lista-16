using CadastroSetores;
using MySql.Data.MySqlClient;
using System.Data;
using testev2;

namespace atividade_lista_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.RowHeadersVisible = false;
            dgvFuncionarios.ClearSelection();
        }
        private void ListarTodosFuncionarios()
        {
            dgvFuncionarios.DataSource = Funcionario.ListarTodosFuncionarios();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            cbSetor.SelectedIndex = -1;
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
            dtpDataNascimento.Value = DateTime.Today;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(mtbCPF.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(cbSetor.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                (!rbMasculino.Checked && !rbFeminino.Checked))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario
            {
                Nome = txtNome.Text,
                CPF = mtbCPF.Text,
                DataNascimento = dtpDataNascimento.Value,
                Cargo = txtCargo.Text,
                Setor = cbSetor.Text, // ComboBox para o setor
                Sexo = rbMasculino.Checked ? "Masculino" : "Feminino", // RadioButton para o sexo
                Salario = Convert.ToDecimal(txtSalario.Text)
            };

            if (func.InserirFuncionario())
            {
                MessageBox.Show("Funcion�rio cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarTodosFuncionarios();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcion�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione um funcion�rio para editar.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Deseja realmente atualizar este funcion�rio?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(mtbCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtCargo.Text) ||
                    string.IsNullOrWhiteSpace(cbSetor.Text) ||
                    string.IsNullOrWhiteSpace(txtSalario.Text) ||
                    (!rbMasculino.Checked && !rbFeminino.Checked))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Funcionario func = new Funcionario
                {
                    ID = int.Parse(txtID.Text),
                    Nome = txtNome.Text,
                    CPF = mtbCPF.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    Cargo = txtCargo.Text,
                    Setor = cbSetor.Text, // ComboBox para o setor
                    Sexo = rbMasculino.Checked ? "Masculino" : "Feminino", // RadioButton para o sexo
                    Salario = Convert.ToDecimal(txtSalario.Text)
                };

                if (func.AtualizarFuncionario())
                {
                    MessageBox.Show("Funcion�rio atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    ListarTodosFuncionarios();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar funcion�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione um funcion�rio para excluir.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Deseja realmente excluir este funcion�rio?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                Funcionario func = new Funcionario { ID = int.Parse(txtID.Text) };

                if (func.ExcluirFuncionario())
                {
                    MessageBox.Show("Funcion�rio exclu�do com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    ListarTodosFuncionarios();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir funcion�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtNome.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                mtbCPF.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                dtpDataNascimento.Value = Convert.ToDateTime(dgvFuncionarios.Rows[e.RowIndex].Cells["data_nascimento"].Value);
                txtCargo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                cbSetor.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Setor"].Value.ToString();
                txtSalario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                string sexo = dgvFuncionarios.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                rbMasculino.Checked = sexo == "Masculino";
                rbFeminino.Checked = sexo == "Feminino";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite o nome do funcion�rio para pesquisar.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = Funcionario.ListarFuncionarioPorNome(nome);

                dgvFuncionarios.DataSource = dt;

                dgvFuncionarios.AllowUserToAddRows = false; // Remove linha extra (asterisco *)
                dgvFuncionarios.RowHeadersVisible = false;  // Remove a coluna da seta preta
                dgvFuncionarios.ClearSelection();           // N�o seleciona nenhuma c�lula

                if (dgvFuncionarios.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum funcion�rio encontrado.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar funcion�rio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}