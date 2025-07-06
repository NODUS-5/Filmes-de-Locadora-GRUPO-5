using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    internal class ConexaoDB
    {
        //Classe criada com o objetivo de fornecer os dados da conexão do banco de dados.
        public static MySqlConnection fazconexao()
        {
            return new MySqlConnection("server=localhost;port=3306;database=db_locadora;uid=root;pwd=123456789;"); //string de conexão
        }
    }
}
