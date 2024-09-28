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
            string s_ip = "";
            //int i_counter = 0;
            
            int i_prioc = 0;
            int i_segoc = 0;
            int i_teroc = 0;
            int i_quaoc = 0;

            Console.Write("Digite o ip: ");
            s_ip = Console.ReadLine();
            string[] s_ipqb = s_ip.Split('.');
            
            i_prioc = Convert.ToInt16(s_ipqb[0]);
            i_segoc = Convert.ToInt16(s_ipqb[1]);
            i_teroc = Convert.ToInt16(s_ipqb[2]);
            i_quaoc = Convert.ToInt16(s_ipqb[3]);
            
            //Descobrir classe
            if(i_prioc >= 1 && i_prioc <= 127)
            {
                Console.Write("CLASSE DO IP ---> [A]");
            }
            else
            {
                if(i_prioc >= 128 && i_prioc <= 191)
                {
                    Console.Write("CLASSE DO IP ---> [B]");
                }
                else
                {
                    if(i_prioc >= 192 && i_prioc <= 255)
                    {
                        Console.Write("CLASSE DO IP ---> [C]");
                    }
                    else
                    {
                        Console.Write("CLASSE INVALIDA!");
                    }
                }
            }
            //
            Console.ReadLine();
        }
    }
}
//Sendo criado por YagoSP 27/09/2024 
