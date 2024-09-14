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
            int i_num1 = 0;
            int i_num2 = 0;

            Console.WriteLine("Digite um numero: ");
            i_num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            i_num2 = Convert.ToInt16(Console.ReadLine());

            if (i_num1 > i_num2)
            {
                Console.WriteLine("{0} é maior que {1}", i_num1, i_num2);
            }
            else
            {
                if (i_num1 < i_num2)
                {
                    Console.WriteLine("{0} é menor que {1}", i_num1, i_num2);
                }
                else
                {
                    Console.WriteLine("Os numeros são iguais!");
                }
            }
            Console.ReadLine();
        }
    }
}

// Criado por YagoSP 13/09/2024 21:41
