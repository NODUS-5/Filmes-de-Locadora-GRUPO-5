using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    public class FilmeDAO //Filme Dados Acesso Organização: Executa as operações no banco de dados.
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
        public static void ListarTodosFilmes()
        {
            MySqlConnection cn = ConexaoDB.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select titulo, diretor, genero, ano_lancamento, classificacao_indicativa, duracao_minutos from filmes";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("{0,-30} {1,-25} {2,-15} {3,-20} {4,-20} {5,-10}", //{indice, espaçameto}
                        "Título", "Diretor", "Gênero", "Ano de Lançamento", "Classificação", "Duração em minutos");

                    while (dr.Read())
                    {
                        Console.WriteLine("{0,-30} {1,-25} {2,-15} {3,-20} {4,-20} {5,-10}", dr["titulo"], dr["diretor"], dr["genero"], dr["ano_lancamento"],
                            dr["classificacao_indicativa"], dr["duracao_minutos"]);
                    }
                }
                else 
                {
                    Console.WriteLine("Nenhum filme encontrado!");
                }
                dr.Close();
                cn.Close();



            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
            }
        }
        public static void DeletarFilme(int id)
        {
            MySqlConnection cn = ConexaoDB.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from filmes where id= " + id;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Filme deletado com sucesso!! ");
                cn.Close();



            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
            }
        }
        public static void AtualizarCampoFilme(int id, string campo, string novoValor, bool seNumero = false) //seNumero= verificação se é numero ou não, se estiver true o novo valor será sem ""
        {
            MySqlConnection cn = ConexaoDB.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                string valorFormatado = seNumero ? novoValor : $"'{novoValor}'";
                cmd.CommandText = $"update filmes set {campo} = {valorFormatado} where id = {id}";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Campo atualizado com sucesso!");
                cn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao atualizar o filme.\n" + ex.Message);
            }
        }
        public static void BuscarPorId(int id) 
        {
            MySqlConnection cn = ConexaoDB.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from filmes where id= " + id;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Filme Selecionado: \n");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("{0,-30} {1,-25} {2,-15} {3,-20} {4,-20} {5,-10}", //{indice, espaçameto}
                        "Título", "Diretor", "Gênero", "Ano de Lançamento", "Classificação", "Duração em minutos");

                    while (dr.Read())
                    {
                        Console.WriteLine("{0,-30} {1,-25} {2,-15} {3,-20} {4,-20} {5,-10}", dr["titulo"], dr["diretor"], dr["genero"], dr["ano_lancamento"],
                            dr["classificacao_indicativa"], dr["duracao_minutos"]);
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum filme encontrado!");
                }
                dr.Close();
                cn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
            }

        }



    }
}
