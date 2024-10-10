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
            Console.Write("Digite um valor de 1 a 12 para saber o mês: ");
            i_numero = Convert.ToInt32(Console.ReadLine());
            switch (i_numero)
            {
                case 1:
                    Console.Write("JANEIRO");
                    break;
                case 2:
                    Console.Write("FEVEREIRO");
                    break;
                case 3:
                    Console.Write("MARÇO");
                    break;
                case 4:
                    Console.Write("ABRIL");
                    break;
                case 5:
                    Console.Write("MAIO");
                    break;
                case 6:
                    Console.Write("JUNHO");
                    break;
                case 7:
                    Console.Write("JULHO");
                    break;
                case 8:
                    Console.Write("AGOSTO");
                    break;
                case 9:
                    Console.Write("SETEMBO");
                    break;
                case 10:
                    Console.Write("OUTUBRO");
                    break;
                case 11:
                    Console.Write("NOVEMBRO");
                    break;
                case 12:
                    Console.Write("DEZEMBRO");
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
//Criado por YagoSP 10/10/2024 20:26
