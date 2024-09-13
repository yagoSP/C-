using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace atividade13092024
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            do
            {
                Console.Clear();
                int i_num1;
                Console.WriteLine("digite um  numero: ");
                i_num1 = Convert.ToInt16(Console.ReadLine());
                if (i_num1 % 2 == 0)
                {
                    Console.WriteLine("O numero é par!");
                }
                else
                {
                    Console.WriteLine("O numero é impar!");
                }
                Console.ReadLine();
                Console.WriteLine("Deseja outra consulta: (S/N)");
 
            } while (Console.ReadLine().ToUpper() == "S");
 
        }
    }
}
// Criado por Luis (Malvadão) & Facine (Monstro)  13/09/2024 20:27 (SEXTA FEIRA 13 HAHAHAHAHAHAHAH)
