using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13092024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s_palavra1 = "";
            string s_palavra2 = "";
            int i_tamPalv1 = 0;
            int i_tamPalv2 = 0;

            Console.Write("Digite uma palavra: ");
            s_palavra1 = Console.ReadLine();
            i_tamPalv1 = s_palavra1.Length;
            Console.Write("Digite Outra Palavra: ");
            s_palavra2 = Console.ReadLine();
            i_tamPalv2 = s_palavra2.Length;

            if(i_tamPalv1 > i_tamPalv2)
            {
                Console.WriteLine("\"{0}\" é maior que \"{1}\"", s_palavra1, s_palavra2);
              
            }
            else
            {
                if(i_tamPalv1 < i_tamPalv2)
                {
                    Console.WriteLine("\"{0}\" é menor que \"{1}\"", s_palavra1, s_palavra2);
                }
                else
                {
                    Console.WriteLine("As palavras tem o mesmo tamanho!");
                }
            }
            Console.ReadLine();
        }
    }
}
// Criado por YagoSP 13/09/2024 22:12
