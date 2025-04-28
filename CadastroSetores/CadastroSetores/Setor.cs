using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroSetores
{
    internal class Setor
    {
        private int id;
        private string nome;
      
     
        public int Id

        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public bool InserirSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                
                    string inserir = "INSERT INTO setor  (Nome, Id) values (@Nome, @Id);";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Id", Id); 
                    

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir setor ->", ex.Message);
                return false;
            }
        }

        public bool AtualizarSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string atualizar = "UPDATE setor SET Nome = @Nome WHERE Id = @Id;";

                    using (MySqlCommand comando = new MySqlCommand(atualizar, conexaoBanco))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Id", Id);

                        int resultado = comando.ExecuteNonQuery();

                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar setor: {ex.Message}");
                return false;
            }
        }

        public bool ExcluirSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string atualizar = "DELETE FROM setor WHERE Id = @Id;";

                    using (MySqlCommand comando = new MySqlCommand(atualizar, conexaoBanco))
                    {
                        comando.Parameters.AddWithValue("@Id", Id);

                        int resultado = comando.ExecuteNonQuery();

                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar o setor setor: {ex.Message}");
                return false;
            }
        }

            public static DataTable ListarSetorPorNome(string nome)
            {
                try
                {
                    using (MySqlConnection conexao = new ConexaoBD().Conectar())
                    {
                        string listar = "SELECT Id, Nome FROM Setor WHERE Nome LIKE @Nome";
                        MySqlCommand comando = new MySqlCommand(listar, conexao);
                        comando.Parameters.AddWithValue("@Nome", $"%{nome}%");

                        MySqlDataAdapter da = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar setor! " + ex.Message);
                    return null;
                }
            }

        public static DataTable ListarTodosSetor()
        {
            try
            {
                using(MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string listarTodos = "SELECT Id, Nome FROM setor";
                    MySqlDataAdapter coamndo = new MySqlDataAdapter(listarTodos, conexao);
                    DataTable dataTable = new DataTable();
                    coamndo.Fill(dataTable);
                    return dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os setores!" + ex.Message);
                return null;
            }
        }
    }
}
