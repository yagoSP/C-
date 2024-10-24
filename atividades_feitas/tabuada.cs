using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_tabuada = 0;
            Console.Write("Digite a tabuada: ");
            i_tabuada = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i_tabuada} x {i} = {i_tabuada * i}");
            }
            Console.ReadLine();
        }
    }
}
//CRIADO POR YAGOSP 24/10/2024
