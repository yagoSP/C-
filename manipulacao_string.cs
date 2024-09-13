using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace atividade_cisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATIVIDADE 1
            string s_palavra1, s_palavra2;
            Console.WriteLine("Digite Uma Palavra: ");
            s_palavra1 = Console.ReadLine();
            Console.WriteLine("Digite Outra Palavra");
            s_palavra2 = Console.ReadLine();
            Console.WriteLine("{0}", s_palavra1 + s_palavra2);

            //Atividade 2
            Console.WriteLine("Imprima a primeira letra das duas variaveis\n");
            Console.WriteLine("\n{0} {1}\n", s_palavra1.Substring(0, 1),  s_palavra2.Substring(0, 1));

            //Atividade 3
            Console.WriteLine("Imprima as duas ultimas letras das duas variaveis\n");
            Console.WriteLine("\n{0} {1}\n", s_palavra1.Substring(s_palavra1.Length - 1, 1), s_palavra2.Substring(s_palavra2.Length -1, 1));

            //Atividade 4
            Console.WriteLine("Imprima todos os caracteres menos o primeiro\n");
            Console.Write("\n{0} {1}\n",s_palavra1.Substring(1), s_palavra2.Substring(1));

            //Atividade 5
            Console.WriteLine("Imprima todos os caracteres menos o ultimo\n");
            Console.WriteLine("\n{0} {1}\n", s_palavra1.Substring(0, s_palavra1.Length - 1), s_palavra2.Substring(0, s_palavra2.Length -1));
            Console.ReadLine();

        }
    }
}
