using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_mes = 0;
            i_mes = PegaIntRange("Digite o numero correspondente a um mes: ", 1, 12);
            string[] s_mes =
            {
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Março",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };
            Console.Write($"{s_mes[i_mes - 1]}");
            Console.ReadLine();
        }
        static int PegaIntRange(string ps_msg, int pi_Min, int pi_Max)                    /*Sinceramente...
        {                                                                                   Eu não entendi porra nenhuma do que acontece dentro dessa função :)
            int i_Nro = 0;                                                                */
            bool b_Valida = false;
            do
            {
                Console.Write(ps_msg);
                b_Valida = int.TryParse(Console.ReadLine(), out i_Nro);
                b_Valida = i_Nro >= pi_Min && i_Nro <= pi_Max;
            } while(!b_Valida);

            return i_Nro;
        }
    }
}
//Criado por yagoSP (menos a função aqui em baixo pq foi o facine que fez :( ) 07/11/2024
