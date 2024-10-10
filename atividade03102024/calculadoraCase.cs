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
            string op = "";
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("Operadores validos + - X /");
            Console.Write("Digite um operador: ");
            op = Console.ReadLine().ToUpper();

            if(op != "+" && op != "-" && op != "X" && op != "/")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operador Invalido!");
                Console.ReadLine();
                return;
            }
            
            Console.Write("Digite um numero: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.Write($"{n1} + {n2} = {n1 + n2}");
                    break;
                
                case "-":
                    Console.Write($"{n1} - {n2} = {n1 - n2}");
                    break;
                case "X":
                    Console.Write($"{n1} x {n2} = {n1 * n2}");
                    break;
                case "/":
                    Console.Write($"{n1} / {n2} = {n1/n2}");
                    break;
                default:
                    Console.Write("Erro");
                    break;
            }


            Console.ReadLine();
        }


    }
}
//Criado por YagoSP 10/10/2024 20:10 (Não sei se eu ja fiz esse código para c#)
