// 1. Escreva um programa para ler 2 valores (considere que não serão informados valores iguais) e escrever o maior deles.  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade190924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_num1 = 0;
            int i_num2 = 0;
            Console.Write("Digite um numero: ");
            i_num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            i_num2 =  Convert.ToInt16(Console.ReadLine());

            if(i_num1 > i_num2)
            {
                Console.Write("{0} é o maior!", i_num1);
            }
            else
            {
                if(i_num2 > i_num1)
                {
                    Console.Write("{0} é o maior!");
                }
            }
            Console.ReadLine();
        }
    }
}
