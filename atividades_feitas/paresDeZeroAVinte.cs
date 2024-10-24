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
            for (int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();
        }
    }
}
//CRIADO POR YAGOSP 24/10/2024
