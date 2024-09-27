using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_n1 = 0;
            int i_n2 = 0;
            int i_n3 = 0;
            int i_media = 0;

            Console.Write("Digite o primeiro valor: ");
            i_n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            i_n2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            i_n3 = Convert.ToInt16(Console.ReadLine());

            i_media = (i_n1 + i_n2 + i_n3) / 3;
            if(i_media >= 7)
            {
                Console.Write("Aprovado!");
            }
            else
            {
                if(i_media >= 5 && i_media < 7)
                {
                    Console.Write("Recuperação!");
                }
                else
                {
                    if(i_media < 5)
                    {
                        Console.Write("Reprovado!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
// Criado por YagoSP 26/09/2024 21:37
