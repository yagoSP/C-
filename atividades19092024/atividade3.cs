/*
Escreva um programa que verifique a validade de uma senha
fornecida pelo usuário. A senha válida é o número 1234. Devem ser impressas as 
seguintes mensagens: ACESSO PERMITIDO caso a senha seja válida. ACESSO NEGADO caso a senha seja inválida.  
*/
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
            string senha = "";

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
            if(senha == "1234")
            {
                Console.Write("Acesso Garantido!");
            }
            else
            {
                Console.Write("Acesso Negado!");
            }
            Console.ReadLine();
        }
    }
}
