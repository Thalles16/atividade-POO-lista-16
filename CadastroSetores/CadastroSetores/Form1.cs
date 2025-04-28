using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace CadastroSetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

      



        private void DtvSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DtvSetores.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        private List<Setor> listaSetores = new List<Setor>();
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtID.Text))
                {
                    if (int.TryParse(txtID.Text, out int id))
                    {
                        bool idDuplo = listaSetores.Any(s => s.Id == id);
                        if (idDuplo)
                        {
                            MessageBox.Show("Este Id já existe!");
                            return;
                        }

                        Setor NovoSetor = new Setor();
                        NovoSetor.Nome = txtNome.Text;
                        NovoSetor.Id = id;
                        listaSetores.Add(NovoSetor);

                        if (NovoSetor.InserirSetor())
                        {
                            MessageBox.Show("Cadastro do setor realizado com sucesso!");
                            txtID.Clear();
                            txtNome.Clear();
                           
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o setor!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insira um ID válido (número inteiro)!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para gravar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir setor: " + ex.Message);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtID.Text, out int id))
                {
                    DialogResult confirmar = MessageBox.Show("Tem certeza que deseja excluir o setor?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        Setor excluirSetor = new Setor();
                        excluirSetor.Id = id;

                        if (excluirSetor.ExcluirSetor())
                        {
                            MessageBox.Show("Setor excluido com sucesso!");
                            txtID.Clear();
                            txtNome.Clear();
                            DtvSetores.DataSource = Setor.ListarTodosSetor();

                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel excluir o setor!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("O ID está incorreto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir setor" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    if (int.TryParse(txtID.Text, out int id))
                    {
                        Setor Atualizar = new Setor();
                        Atualizar.Id = id;
                        Atualizar.Nome = txtNome.Text;

                        if (Atualizar.AtualizarSetor())
                        {
                            MessageBox.Show("Setor atualizado com sucesso!");
                            txtID.Clear();
                            txtNome.Clear();
                            DtvSetores.DataSource = Setor.ListarTodosSetor();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel atualizar o setor!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Esse Id não existe ou esta incorreto");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar setor" + ex.Message);
            }
        }

        private void txtSetor_TextChanged(object sender, EventArgs e)
        {
            string nomeBuscado = txtSetor.Text.Trim();
            DataTable resultado = Setor.ListarSetorPorNome(nomeBuscado);

            if (resultado != null)
            {
                DtvSetores.DataSource = resultado;
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            DataTable resultados = Setor.ListarTodosSetor();
            DtvSetores.DataSource = resultados;
        }
    }
}
