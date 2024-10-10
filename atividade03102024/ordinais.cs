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
            int i_numero = 0;
            Console.Write("Digite um valor de 1 a 10: ");
            i_numero = Convert.ToInt32(Console.ReadLine());
            switch (i_numero)
            {
                case 1:
                    Console.Write("Primeiro");
                    break;
                case 2:
                    Console.Write("Segundo");
                    break;
                case 3:
                    Console.Write("Terceiro");
                    break;
                case 4:
                    Console.Write("Quarto");
                    break;
                case 5:
                    Console.Write("Quinto");
                    break;
                case 6:
                    Console.Write("Sexto");
                    break;
                case 7:
                    Console.Write("Sétimo");
                    break;
                case 8:
                    Console.Write("Oitavo");
                    break;
                case 9:
                    Console.Write("Nono");
                    break;
                case 10:
                    Console.Write("Décimo");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Siga as regras do programa!!!");
                    break;
            }
            Console.ReadLine();
        }


    }
}
//Criado por YagoSP 10/10/2024 20:21
