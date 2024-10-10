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
            string s_senha = "";
            int i_nivel = 0;

            Console.Write("Digite o seu nível de privilégio: ");
            i_nivel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a senha: ");
            s_senha = Console.ReadLine();


            if(i_nivel > 3 || i_nivel < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nível Inválido!!!");
                return;
            }
            
            if(i_nivel == 1 && s_senha == "user123")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CONTA USER ACESSADA COM SUCESSO!");
            }
            else if(i_nivel == 2 && s_senha == "tecnico123")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CONTA TÉCNICO ACESSADA COM SUCESSO!");
            }
            else if(i_nivel == 3 && s_senha == "root123")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CONTA ROOT ACESSADA COM SUCESSO!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ACESSO NEGADO!");
            }
            Console.ReadLine();
        }


    }
}
//Criado por YagoSP 10/10/2024 20:39
