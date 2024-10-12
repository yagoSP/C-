using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_num = 0;
            int x = 1;
            Console.Write("Digite um numero: ");
            i_num = Convert.ToInt32(Console.ReadLine());

            while (x < i_num)
            {
                
                for (int i = 1; i <= x; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                x++;''
            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP & Hugo 11/10/2024 21:54
