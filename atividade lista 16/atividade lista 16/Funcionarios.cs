using CadastroSetores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace testev2
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Sexo { get; set; }
        public decimal Salario { get; set; }

        public bool InserirFuncionario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "INSERT INTO funcionarios (nome, cpf, data, cargo, setor, sexo, salario) VALUES (@nome, @cpf, @data, @cargo, @setor, @sexo, @salario)";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@cpf", CPF);
                    comando.Parameters.AddWithValue("@data", DataNascimento);
                    comando.Parameters.AddWithValue("@cargo", Cargo);
                    comando.Parameters.AddWithValue("@setor", Setor);
                    comando.Parameters.AddWithValue("@sexo", Sexo);
                    comando.Parameters.AddWithValue("@salario", Salario);
                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir funcionário:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
        }
        public bool AtualizarFuncionario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, data = @data, cargo = @cargo, setor = @setor, sexo = @sexo, salario = @salario WHERE id = @id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", ID);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@cpf", CPF);
                    comando.Parameters.AddWithValue("@data", DataNascimento);
                    comando.Parameters.AddWithValue("@cargo", Cargo);
                    comando.Parameters.AddWithValue("@setor", Setor);
                    comando.Parameters.AddWithValue("@sexo", Sexo);
                    comando.Parameters.AddWithValue("@salario", Salario);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
        }

        public bool ExcluirFuncionario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "DELETE FROM funcionarios WHERE id = @id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", ID);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar funcionário:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
        }
        public static DataTable ListarTodosFuncionarios()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT * FROM funcionarios";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar funcionários:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
            return tabela;
        }

        public static DataTable ListarFuncionarioPorNome(string nome)
        {
            DataTable tabela = new DataTable();
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT * FROM funcionarios WHERE nome LIKE @nome";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar funcionários:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
            return tabela;
        }
    }
}