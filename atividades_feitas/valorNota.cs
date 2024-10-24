using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d_valorDaNota = 0;
            string s_mensagem = "VALOR DA NOTA CALCULADA: ";
            Console.Write("Digite o valor da nota: ");
            d_valorDaNota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (d_valorDaNota > 0.00 && d_valorDaNota <= 999.99)
            {
                Console.Write(s_mensagem + (d_valorDaNota + (d_valorDaNota * 0.02)));

            }
            else if (d_valorDaNota >= 1000.00 && d_valorDaNota <= 2999.99)
            {
                Console.Write(s_mensagem + (d_valorDaNota + (d_valorDaNota * 0.025)));
            }
            else if (d_valorDaNota >= 3000.00 && d_valorDaNota <= 6999.99)
            {
                Console.Write(s_mensagem + (d_valorDaNota + (d_valorDaNota * 0.028)));
            }
            else if (d_valorDaNota >= 7000.00)
            {
                Console.Write(s_mensagem + (d_valorDaNota + (d_valorDaNota * 0.03)));
            }
            else
            {
                Console.Write("Valor Inválido!");
            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP 24/10/2024
