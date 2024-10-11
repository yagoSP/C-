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
            int i_tab = 0;

            Console.Write("Qual tabuada: ");
            i_tab = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<= 10; i++)
            {
                Console.WriteLine($"{i_tab} x {i} = {i_tab * i}");
            }
            Console.ReadLine();
        
        
        
        
        
        }


    }
}  
//Criado por YagoSP 11/10/2024 20:10
