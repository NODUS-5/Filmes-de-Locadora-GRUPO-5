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
            int opcao=0;
            do {
                try {
                    Console.WriteLine("\n-------Menu-------");
                    Console.WriteLine("1 - Adicionar Filme\n2 - Editar Filme\n3 - Remover Filme\n4 - Listar filmes\n5 - Buscar por filtro\n6 - Sair do Sistema ");
                    Console.Write("Digite a opção desejada: ");opcao= int.Parse(Console.ReadLine());
                    switch (opcao) 
                    {
                        case 1:
                            FilmeControlador.AdicionarFilme();break;
                        case 2:
                            FilmeControlador.EditarFilme(); break;
                        case 3:
                            FilmeControlador.RemoverFilme(); break;
                        case 4:
                            FilmeControlador.ListarTodosFilmes(); break;
                        case 5:
                            FilmeControlador.BuscarFilmesPor();break;
                        case 6:
                            Console.WriteLine("Sistema Finalizando...");break;
                        default:
                            Console.WriteLine("Por favor, digite um valor entre 1 e 6!!"); break;


                    
                    
                    }
                
                
                } catch (Exception) {
                    Console.WriteLine("Digite um valor válido!!");
                }
            
            
            }while (opcao!=6);
        }
    }
}
