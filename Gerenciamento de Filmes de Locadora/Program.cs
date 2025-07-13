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
            int opcao;
            do {
                try {
                    Console.WriteLine("-----Menu-----");
                    Console.WriteLine("1 - Adicionar Filme\n2- Editar Filme\n3 - Remover Filme\n4 - Listar filmes\n 5 - Buscar por filtro\n6 - Sair do Sistema ");
                    Console.Write("Digite a opção desejada: ");opcao= int.Parse(Console.ReadLine());
                
                
                } catch (Exception ex) {
                    Console.WriteLine("Digite um valor válido!!");
                }
            
            
            }while (true);
        }
    }
}
