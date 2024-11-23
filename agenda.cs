using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        public struct Contato
        {
            public string s_Nm_Contato { get; set; }
            public string s_Cel_Contato {get; set; }
            public string s_Mail_Contato { get; set; }
            public string s_End_Contato { get; set; }
            public string s_Bai_Contato { get; set; }
            public string s_Cid_Contato { get; set; }
            public string s_Uf_Contato { get; set; }
            public string s_Cep_Contato { get; set; }


        }
        static void Main(string[] args)
        {
            int i_control = 1;
            ConsoleKeyInfo = c_Key
            do
            {
                MontaTela(i_control);
                c_Key = Console.ReadKey().Key;
                if(c_Key == ConsoleKey.UpArrow)
                {
                    if(i_control != 6)
                    {
                        i_control += 1;
                    }
                    else
                    {
                        i_control = 1;
                    }
                }
            }

            MontaTela(1);
            Console.ReadLine();
            MontaTela(2);
            Console.ReadLine();
            MontaTela(3);
            Console.ReadLine();
            MontaTela(4);
            Console.ReadLine();

        }while
        static void MontaTela(int i_tela)
        {
            Console.Clear();
            switch (i_tela)
            {
                case 1:
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║          M E N U         ║");
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.Write("║");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" [");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("] - Adicionar          ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("║");
                    Console.WriteLine("║ [2] - Consultar Todos    ║");
                    Console.WriteLine("║ [3] - Consultar por Nome ║");
                    Console.WriteLine("║ [4] - Alterar            ║");
                    Console.WriteLine("║ [5] - Excluir            ║");
                    Console.WriteLine("║ [6] - Sair               ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.ReadLine();
                    break;
               
                case 2:
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║          M E N U         ║");
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.WriteLine("║ [1] - Adicionar          ║");
                    Console.Write("║");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" [");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("] - Consultar Todos    ");
                    Console.BackgroundColor= ConsoleColor.Black;
                    Console.WriteLine("║");
                    Console.WriteLine("║ [3] - Consultar por Nome ║");
                    Console.WriteLine("║ [4] - Alterar            ║");
                    Console.WriteLine("║ [5] - Excluir            ║");
                    Console.WriteLine("║ [6] - Sair               ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║          M E N U         ║");
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.WriteLine("║ [1] - Adicionar          ║");
                    Console.WriteLine("║ [2] - Consoltar Todos    ║");
                    Console.Write("║");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" [");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("] - Consultar por Nome ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("║");
                    Console.WriteLine("║ [4] - Alterar            ║");
                    Console.WriteLine("║ [5] - Excluir            ║");
                    Console.WriteLine("║ [6] - Sair               ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║          M E N U         ║");
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.WriteLine("║ [1] - Adicionar          ║");
                    Console.WriteLine("║ [2] - Consoltar Todos    ║");
                    Console.WriteLine("║ [3] - Consultar por Nome ║");
                    Console.WriteLine("║");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" [");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("] - Alterar      ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("║");
                    Console.WriteLine("║ [5] - Excluir            ║");
                    Console.WriteLine("║ [6] - Sair               ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.ReadLine();
                    break;

            }
        }

    }
}
