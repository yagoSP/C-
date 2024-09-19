//Escreva um programa para ler o ano de nascimento de uma pessoa e escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que ela nasceu).  
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
            int i_ano_pessoa = 0;
            int i_ano_atual = 0;

            Console.Write("Digite o ano que você nasceu: ");
            i_ano_pessoa = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            i_ano_atual = Convert.ToInt16(Console.ReadLine());

            if(i_ano_atual - i_ano_pessoa >= 18)
            {
                Console.Write("Você pode votar!");
            }
            else
            {
                Console.Write("Você não pode votar!");
            }
            Console.ReadLine();
        }
    }
}
