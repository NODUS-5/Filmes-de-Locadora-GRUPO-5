using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    public class Utils //Classe criada com o objetivo de fornecer funcionalidades genéricas e reutilizáveis.
    {
       
        //public int anoAtual = 
        public static int anoPrimeiroFilme = 1895; //ano do primeiro filme de acordo com wikipedia "História do cinema"


        public static int ObterAnoAtual() //Metodo que retorna o ano corrente para validações.
        {
            return DateTime.Now.Year; //retorna esoecificamente o ano atual
        }
        public static bool ConfirmarOperacao() //Metodo que retorna a confirmação da operação
        {
            int confirmacaoOperacao;
            while (true)
            {
                try
                {
                    Console.Write("\nDeseja confirmar essa operação? \n1- Sim\t2- Não\nDigite a opção deseja:"); confirmacaoOperacao = int.Parse(Console.ReadLine());
                    if (confirmacaoOperacao < 1 || confirmacaoOperacao > 2)
                    {
                        Console.WriteLine("Por favor, digite um número de confirmação entre 1 e 2!");

                    }
                    else 
                    {
                        if(confirmacaoOperacao == 1) { Console.WriteLine("Operação confirmada!!"); return true; }
                        else { Console.WriteLine("Operação negada!!"); return false; }
                    }

                }
                catch(FormatException) { Console.WriteLine("O valor digitado não é válido, digite um número de confirmação entre 1 e 2!"); }

            }
        }
    }
}
