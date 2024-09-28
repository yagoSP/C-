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
            //Declaração de variáveis		
	    string s_ip = "";
            string s_binmask = "";         
            int i_prioc = 0;
            int i_segoc = 0;
            int i_teroc = 0;
            int i_quaoc = 0;

	    int i_counter = 0;
            int i_cidr = 0;
	    string subnetmask = "";

            Console.Write("Digite o ip: ");
            s_ip = Console.ReadLine();
  	    
	    if(s_ip == "")
	    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("DIGITE UM IP!\n");
		Console.ResetColor();
		return;
	    }	
	
	    string[] s_ipqb = s_ip.Split('.');
                 
	    i_prioc = Convert.ToInt16(s_ipqb[0]);
            i_segoc = Convert.ToInt16(s_ipqb[1]);
            i_teroc = Convert.ToInt16(s_ipqb[2]);
            i_quaoc = Convert.ToInt16(s_ipqb[3]);
	  

	    for(i_counter = 0; i_counter <= 3; i_counter++)
	    {
	    	if(Convert.ToInt16(s_ipqb[i_counter]) > 255 || Convert.ToInt16(s_ipqb[i_counter]) < 0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("IPV4 INVALIDO!\n");
			Console.ResetColor();
			return;
		}
	    }
	  
	    Console.Write("Digite o valor do CIDR: ");
	    i_cidr = Convert.ToInt16(Console.ReadLine());
	

	    if(i_cidr > 32 || i_cidr < 0)
	    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("CIDR INVALIDO!\n");
		Console.ResetColor();
		return;
	    }
	    Console.WriteLine();

	    Console.ForegroundColor = ConsoleColor.Blue;
	    Console.WriteLine(s_ip);

	    


	    //Descobrir classe
            Console.ForegroundColor = ConsoleColor.Green;
            if (i_prioc >= 1 && i_prioc <= 127)
            {
                Console.Write("CLASSE DO IP ---> [A]");
		if(i_cidr != 8)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("\nPOSSIVEL SUB REDE DETECTADA!");
			Console.ForegroundColor = ConsoleColor.Green;
		}
            }
            else
            {
                if(i_prioc >= 128 && i_prioc <= 191)
                {
			Console.Write("CLASSE DO IP ---> [B]");
			if(i_cidr != 16)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
                    		Console.Write("\nPOSSIVEL SUB REDE DETECTADA!");
				Console.ForegroundColor = ConsoleColor.Green;
			}
                }
                else
                {
                    if(i_prioc >= 192 && i_prioc <= 255)
                    {
			Console.Write("CLASSE DO IP ---> [C]");
			if(i_cidr != 24)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
                	        Console.Write("\nPOSSIVEL SUB REDE DETECTADA!");
				Console.ForegroundColor = ConsoleColor.Green;
			}
                    }
                    else
                    {
                        Console.Write("CLASSE INVALIDA!");
                    }
                }
            }
	    
	    




	    //Quantidade de hosts
            Console.Write("\nQUANTIDADE DE HOSTS = {0}\n", Math.Pow(2, 32-i_cidr)-2);
            
	    //Mascara de subrede
	    subnetmask = cidrtomask(i_cidr);
	    Console.WriteLine("MASCARA ---> {0}", subnetmask);
	  
	    uint ui_binmask = uint.MaxValue << (32 - i_cidr);
            s_binmask = Convert.ToString(ui_binmask, 2);
	    Console.Write($"MASCARA EM BINARIO ---> {s_binmask}\n");

	    Console.ReadLine();
        }




	//função para mascara de subrede
	public static string cidrtomask(int i_cidr)
	{
		uint mask = uint.MaxValue << (32 - i_cidr);
		byte[] bytes = BitConverter.GetBytes(mask);
		Array.Reverse(bytes);
		return string.Join('.', bytes);
	}


    }
}

//Sendo Criado por YagoSP 
