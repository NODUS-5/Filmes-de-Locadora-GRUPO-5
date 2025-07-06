using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Filmes_de_Locadora
{
    internal class Utils //Classe criada com o objetivo de fornecer funcionalidades genéricas e reutilizáveis.
    {
        
        private int confirmacaoOperacao;
        private int anoAtual = DateTime.Now.Year;

        public int ObterAnoAtual() //Metodo que retorna o ano corrente para validações.
        {
            return anoAtual;
        }
        public bool ConfirmarOperacao() //Metodo que retorna a confirmação da operação
        {
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
