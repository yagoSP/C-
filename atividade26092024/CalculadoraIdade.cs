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
            int i_idade = 0;
            Console.Write("Digite a idade: ");
            i_idade = Convert.ToInt16(Console.ReadLine());

            if(i_idade >= 0 && i_idade <= 12)
            {
                Console.Write("Criança!");
            }
            else
            {
                if(i_idade >= 13 && i_idade <= 17)
                {
                    Console.Write("Adolescente!");
                }
                else
                {
                    if(i_idade >= 18 && i_idade <= 64)
                    {
                        Console.Write("Adulto!");
                    }
                    else
                    {
                       if(i_idade > 65)
                        {
                            Console.Write("Idoso!");
                        }
                        else
                        {
                            Console.Write("Idade Invalida!");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP 26/09/2024 21:45
//Preciso revisar esse código LIXO
