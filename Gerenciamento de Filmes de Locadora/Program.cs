using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = ConexaoDB.fazconexao(); //faz a conexão com a classe do banco de dados

            try
            {
                conexao.Open();
                Console.WriteLine("Conectado");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "Select * from filmes limit 1";
                MySqlDataReader dr = cmd.ExecuteReader();

            }
            catch (MySqlException erro)
            {
                Console.WriteLine(erro.Message);
                return;
            }
        }
    }
}
