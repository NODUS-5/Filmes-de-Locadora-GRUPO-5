using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    public class FilmeControlador //Orquestra as operações de filmes.
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
            while (true)
            {
                try 
                {
                    Console.WriteLine("\nlista de IDs (Expanda a tela para melhor visualização)");
                    FilmeDAO.ListarTodosFilmes();
                    Console.Write("Digite o id do Filme que deseja editar: "); int filmeEditar = int.Parse(Console.ReadLine());
                    if (filmeEditar <= 0) 
                    {
                        Console.WriteLine("Por favor, digite um número maior que zero.");
                    }else {
                        if (FilmeDAO.ExisteId(filmeEditar))
                        {
                            Console.WriteLine("Campo para alteração:\n1- Titulo\n2- Diretor\n3- Genero\n4- Ano de Lançamento\n5- Classificação indicativa\n6- Duração do filme");
                            Console.Write("Digite a opção desejada: "); int opcaoCampo = int.Parse(Console.ReadLine());
                            if (opcaoCampo < 1 || opcaoCampo > 6)
                            {
                                Console.WriteLine("Digite um número entre 1 e 7.");
                            }
                            else
                            {
                                switch (opcaoCampo)
                                {
                                    case 1:
                                        Console.Write("Digite o novo Título: ");
                                        string novoTitulo = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "titulo", novoTitulo); }
                                        break;
                                    case 2:
                                        Console.Write("Digite o novo Diretor: ");
                                        string novoDiretor = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "diretor", novoDiretor); }
                                        break;
                                    case 3:
                                        Console.Write("Digite o novo Gênero: ");
                                        string novoGenero = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "genero", novoGenero); }
                                        break;
                                    case 4:
                                        Console.Write("Digite o novo Ano de Lançamento: ");
                                        string novoAno = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "ano_lancamento", novoAno, true); }
                                        break;
                                    case 5:
                                        Console.Write("Digite a nova Classificação Indicativa: ");
                                        string novaClassificacao = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "classificacao_indicativa", novaClassificacao); }
                                        break;
                                    case 6:
                                        Console.Write("Digite a nova Duração do filme (em minutos): ");
                                        string novaDuracao = Console.ReadLine();
                                        if (Utils.ConfirmarOperacao()) { FilmeDAO.AtualizarCampoFilme(filmeEditar, "duracao_minutos", novaDuracao, true); }
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida. Por favor, escolha uma das opções do menu.");
                                        break;
                                }
                                break;
                            }
                        }
                        else { Console.WriteLine("Por favor, digite um id existente."); }
                    }
                } catch (Exception) { Console.WriteLine("O valor digitado não é válido!"); }
            }
            
        }
        public static void RemoverFilme()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Lista de Filmes:");
                    FilmeDAO.BuscarPorId();
                    Console.Write("Digite o id do Filme que deseja deletar: "); int id = int.Parse(Console.ReadLine());
                    if (id <= 0)
                    {
                        Console.WriteLine("Por favor digite um id válido.");
                    }
                    else
                    {
                        if (FilmeDAO.ExisteId(id))
                        {
                            if (Utils.ConfirmarOperacao())
                            {
                                FilmeDAO.DeletarFilme(id);
                                break;
                            }
                            else { break; }
                        } else { Console.WriteLine("Por favor, digite um id existente."); }
                    }
                    Console.Write("\nDigite o titulo do filme: "); string tituloFilme = Console.ReadLine();
                }
                catch (Exception) { Console.WriteLine("Digite um valor válido!!"); }
            }
        }

        public static void ListarTodosFilmes()
        {
            Console.WriteLine("\nLista com todos os filmes (expandir a tela para melhor visualização):");
            FilmeDAO.ListarTodosFilmes();
        }
        public static void BuscarFilmesPor()
        {
            while (true)
            {
                try {
                    Console.WriteLine("\nFiltrar por:\n1- Id\n2- Titulo\n3- Diretor\n4- Genero\n5- Ano de Lançamento\n6- Classificação indicativa\n7- Duração do filme");
                    Console.Write("Digite a opção desejada: "); int opcaoFiltro = int.Parse(Console.ReadLine());
                    if (opcaoFiltro < 1 || opcaoFiltro > 7)
                    {
                        Console.WriteLine("Digite um número entre 1 e 7.");
                    }
                    else
                    {
                        switch (opcaoFiltro)
                        {
                            case 1:
                                Console.Write("Digite o id para a busca: "); string idFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("id",idFiltro, true);
                                break;
                            case 2:
                                Console.Write("Digite o titulo que deseja buscar: "); string tituloFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("titulo",tituloFiltro);
                                break;
                            case 3:
                                Console.Write("Digite o diretor que deseja buscar: "); string diretorFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("diretor", diretorFiltro);
                                break;
                            case 4:
                                Console.Write("Digite o gênero que deseja buscar: "); string generoFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("genero", generoFiltro);
                                break;
                            case 5:
                                Console.Write("Digite o ano de lançamento para a busca: "); string anoFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("ano_lancamento", anoFiltro, true);
                                break;
                            case 6:
                                Console.Write("Digite a classificação indicativa para a busca: "); string classificacaoFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("classificacao_indicativa", classificacaoFiltro);
                                break;
                            case 7:
                                Console.Write("Digite a duração do filme para a busca (em minutos): "); string duracaoFiltro = Console.ReadLine();
                                FilmeDAO.ListarPorFiltro("duracao_minutos", duracaoFiltro, true);
                                break;
                            default:
                                Console.WriteLine("Valor digitado não é válido.");
                                break;
                        }
                        break;
                    }
                } catch (Exception) { Console.WriteLine("Digite um valor válido!!"); }
            }
        }
    }
}
