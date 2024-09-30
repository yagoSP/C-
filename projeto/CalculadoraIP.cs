using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis		
	    string s_ip = "";
            string s_binmask = "";         
	    int i_counter = 0;
            int i_cidr = 0;
	    string subnetmask = "";
	    int[] iparray = new int[4];


            Console.Write("Digite o ip: ");
            s_ip = Console.ReadLine();
  	    
	    if(s_ip == "")
	    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("DIGITE UM IP!\n");
		Console.ResetColor();
		return;
	    }	
	
	    /* Aqui o programa recebe os valores separados por '.' e joga dentro de um array em forma de string
	       Depois disso o programa converte os valores de string para int e joga dentro de outro array
	       chamado iparray */
	    string[] s_ipqb = s_ip.Split('.');
	    for(i_counter = 0; i_counter <= 3; i_counter++)
	    {
		iparray[i_counter] = Convert.ToInt16(s_ipqb[i_counter]);
	    }	  


	    
	    /* Aqui o programa verifica se o IPV4 é valido.
	       O primeiro octeto tem que ter um valor entre 1 e 255 */
	    for(i_counter = 0; i_counter <= 3; i_counter++)
	    {
	    	if(Convert.ToInt16(s_ipqb[0]) > 255 || Convert.ToInt16(s_ipqb[0]) < 1)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("IPV4 INVALIDO!\n");
			Console.ResetColor();
			return;
		}
	    }
	  

	    //Aqui o programa pede a inserção do CIDR e verifica se o cidr é valido.
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



	    //Aqui apenas mostra o IP que você digitou :)
	    Console.ForegroundColor = ConsoleColor.Blue;
	    Console.WriteLine(s_ip);

	    


	    //Descobrir classe e detectar se tem alguma sub rede pelo cidr
            Console.ForegroundColor = ConsoleColor.Green;
            if (iparray[0] >= 1 && iparray[0] <= 127)
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
                if(iparray[0] >= 128 && iparray[0] <= 191)
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
                    if(iparray[0] >= 192 && iparray[0] <= 255)
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
	  
	    //Mascara de rede em binario
	    uint ui_binmask = uint.MaxValue << (32 - i_cidr);
            s_binmask = Convert.ToString(ui_binmask, 2);
	    Console.Write($"MASCARA EM BINARIO ---> {s_binmask}\n");

	    //Essa parte eu peguei de um lugar onde muitos vão me julgar... mas deu certo.
	    using (Ping ping = new Ping())
	    {
		try
		{
			PingReply reply = ping.Send(s_ip);
			if(reply.Status == IPStatus.Success)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write($"Conexão estabelecida com {s_ip}!");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Falha na conectividade!");				
			}
	 	}
		catch (Exception ex)
		{
			Console.WriteLine($"Erro: {ex.Message}");
		}
	    }
	    



	    Console.ReadLine();
        

   	  //for(i_counter = 0; i_counter <= 3; i_counter++)
	  //{
	  //	Console.Write($"{Convert.ToString(iparray[i_counter])}\n");
	  //}



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
//Sendo Criado por YagoSP 27/09/2024 
