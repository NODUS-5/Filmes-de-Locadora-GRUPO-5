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
            //FilmeDAO.InserirFilme("teste","kayo","Ação",2025,"18 anos",120);
            //FilmeDAO.ListarTodosFilmes();
            // FilmeDAO.DeletarFilme(2);
            //FilmeDAO.AtualizarCampoFilme(3, "titulo", "O Chefão Recarregado");//Alterar o título (tipo texto)
            //FilmeDAO.AtualizarCampoFilme(3, "duracao_minutos", "190", true);//Alterar duração (tipo número)
            //FilmeDAO.ListarTodosFilmes();
            FilmeDAO.BuscarPorId(1);



        }
    }
}
