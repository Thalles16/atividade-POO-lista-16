using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSetores
{
    internal class ConexaoBD
    {
  
        private string conexaoBanco = "Server=localhost; Database=cadastrosetores; Uid=root; Pwd=23041975;";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);
            conexao.Open();
            return conexao;
        }
    }
}
