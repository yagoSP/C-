/*
4. Somatório de Números de 1 a N 
Calcular o somatório de uma sequência de números. 
Crie um programa que peça ao usuário um número inteiro N e use um laço for para calcular a soma de todos os números de 1 a N. 
*/
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
            int i_n = 0;
            int i_acm = 0;
            Console.Write("Digite um numero: ");
            i_n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= i_n; i++)
            {
                i_acm += i;
                Console.WriteLine(i_acm);

            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP 11/10/2024 20:22
//OBS: Esse eu não entendi muito bem... Rever a linha 26 (i_acm += i;)
