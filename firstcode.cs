using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_05._09._2005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mensagem de Hello World!
            Console.WriteLine("Hello World!");
            // Digite um Nome
            Console.WriteLine("Paulin Habba");
            // Digite a multiplicacao entre 87 e 32
            Console.WriteLine("87 x 32 = {0}", 87 * 32);
            // Imprima a medie entre 7 3 7 2
            Console.WriteLine("A media entre 7 3 7 2 e {0}", (7 + 3 + 7 + 2) / 4);
            // Ler dois valores e somar

            int i_num1;
            int i_num2;
            Console.WriteLine("Digite o primeiro numero: ");
            i_num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            i_num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", i_num1, i_num2, i_num1 + i_num2);
            Console.ReadLine();

            
        }
    }
}
// Morra lentamente c# MORRA!!!!!!!
