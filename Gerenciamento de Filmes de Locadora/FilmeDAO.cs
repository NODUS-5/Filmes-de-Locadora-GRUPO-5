using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    public class FilmeDAO
    {
        public static void InserirFilme(string titulo, string diretor,string genero,int anoLancamento,string classiIndicativa,int duracaoMinutos) //método para inserir o filme recebendo todos os parâmetros necessários
        {
            MySqlConnection cn = ConexaoDB.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO filmes (titulo, diretor, genero, ano_lancamento, classificacao_indicativa, duracao_minutos) VALUES ('"+titulo+"','"+diretor+"','"+genero+ "',"+anoLancamento+ ",'"+classiIndicativa+ "',"+duracaoMinutos+")";
                cmd.ExecuteNonQuery();
                cn.Close();
                Console.WriteLine("Filme inserido com sucesso!!");


            }catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
            }
        }

    }
}
