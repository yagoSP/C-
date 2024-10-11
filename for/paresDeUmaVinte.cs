using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=20; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }


    }
}
//Criado por YagoSP 11/10/2024 20:05
