
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
            double valorDaNotaFiscal = 0;
            double valorNotaImposto = 0;
            Console.Write("Digite o valor: ");
            
            valorDaNotaFiscal = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if(valorDaNotaFiscal <= 999)
            {
                valorNotaImposto = valorDaNotaFiscal * 0.02;
                Console.WriteLine($"VALOR DO IMPOSTO = {valorNotaImposto:c}\nVALOR CORRIGIDO = {valorDaNotaFiscal + valorNotaImposto:c}");

            }
            else if(valorDaNotaFiscal <= 2999)
            {
                valorNotaImposto = valorDaNotaFiscal * 0.025;
                Console.WriteLine($"VALOR DO IMPOSTO = {valorNotaImposto:c}\nVALOR CORRIGIDO = {valorDaNotaFiscal + valorNotaImposto:c}");
            }
            else if (valorDaNotaFiscal <= 6999)
            {
                valorNotaImposto = valorDaNotaFiscal * 0.028;
                Console.WriteLine($"VALOR DO IMPOSTO = {valorNotaImposto:c}\nVALOR CORRIGIDO = {valorDaNotaFiscal + valorNotaImposto:c}");
            }
            else if (valorDaNotaFiscal >= 7000)
            {
                valorNotaImposto = valorDaNotaFiscal * 0.03;
                Console.WriteLine($"VALOR DO IMPOSTO = {valorNotaImposto:c}\nVALOR CORRIGIDO = {valorDaNotaFiscal + valorNotaImposto:c}");
            }
            Console.ReadLine();
        }
    }
}
//Criado por YagoSP 26/09/2024 22:09
