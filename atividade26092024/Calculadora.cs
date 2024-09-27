using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c_operador = "";
            int i_n1 = 0;
            int i_n2 = 0;

            Console.Write("Operadores Validos + - / x\nDigite um Operador: ");
            c_operador = Console.ReadLine();

            Console.Write("Digite um numero: ");
            i_n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite outro Numero: ");
            i_n2 = Convert.ToInt16(Console.ReadLine());
            
            if(c_operador == "+")
            {
                Console.Write("{0} + {1} = {2}", i_n1, i_n2, i_n1 + i_n2);
            }
            else
            {
                if(c_operador == "-")
                {
                    Console.Write("{0} - {1} = {2}", i_n1, i_n2, i_n1 - i_n2);
                }
                else
                {
                    if(c_operador == "x")
                    {
                        Console.Write("{0} x {1} = {2}", i_n1, i_n2, i_n1 * i_n2);
                    }
                    else
                    {
                        if(c_operador == "/")
                        {
                            Console.Write("{0} / {1} = {2}", i_n1, i_n2, i_n1 / i_n2);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP 26/09/2024 22:09
