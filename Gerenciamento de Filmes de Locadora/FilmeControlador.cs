using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    public class FilmeControlador //Orquestra as operações de filmes.

            //FilmeDAO.InserirFilme("teste","kayo","Ação",2025,"18 anos",120);
            //FilmeDAO.ListarTodosFilmes();
            // FilmeDAO.DeletarFilme(2);
            //FilmeDAO.AtualizarCampoFilme(3, "titulo", "O Chefão Recarregado");//Alterar o título (tipo texto)
            //FilmeDAO.AtualizarCampoFilme(3, "duracao_minutos", "190", true);//Alterar duração (tipo número)
            //FilmeDAO.ListarTodosFilmes();
            //FilmeDAO.BuscarPorId(1);
            //FilmeDAO.ListarPorFiltro("genero", "Ação");
            //FilmeDAO.ListarPorFiltro("ano_lancamento", "2023", true);
    {
        public static void AdicionarFilme()
        {
            while (true) {
                try
                {
                    Console.Write("\nDigite o titulo do filme: "); string tituloFilme = Console.ReadLine();
                    Console.Write("\nDigite o diretor do filme: "); string diretorFilme = Console.ReadLine();
                    Console.Write("\nDigite o genero do filme: "); string generoFilme = Console.ReadLine();
                    int anoLancamento;
                    while (true) {
                        Console.Write("\nDigite o ano de lançamento do filme: "); anoLancamento = int.Parse(Console.ReadLine());

                        if (anoLancamento > Utils.ObterAnoAtual() || anoLancamento < Utils.anoPrimeiroFilme)
                        {
                            Console.WriteLine("O valor do ano de lançamento do filme digitado não é válido, Digite um valor válido.");
                        }
                        else {
                            break;
                        }
                    }
                    Console.Write("\nDigite a classificação indicativa do filme (ex: 14 anos): "); string classIndicativa = Console.ReadLine();
                    int duracaoFilme;
                    while (true) {
                        Console.Write("\n Digite a duração do filme em minutos: "); duracaoFilme = int.Parse(Console.ReadLine());
                        if (duracaoFilme <= 0) { Console.WriteLine("Por favor, digite um valor maior que 0."); } else { break; }
                    }
                    if (tituloFilme == "" || diretorFilme == "" || generoFilme == "" || classIndicativa == "") { Console.WriteLine("Por favor, não deixe o campos em branco."); }
                    else {
                        FilmeDAO.InserirFilme(tituloFilme, diretorFilme, generoFilme, anoLancamento, classIndicativa, duracaoFilme);
                        break;
                    }
                }
                catch (Exception) { Console.WriteLine("Digite um valor válido!!"); }
            }
        }
        public static void EditarFilme()
        {

        }
        public static void RemoverFilme()
        {

        }
        public static void ListarTodosFilmes()
        {
            Console.WriteLine("\nLista com todos os filmes (expandir a tela para melhor visualização):");
            FilmeDAO.ListarTodosFilmes();
        }
        public static void BuscarFilmesPor()
        {

        }
    }
}
