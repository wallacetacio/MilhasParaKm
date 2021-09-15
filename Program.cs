using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double MilhasEmKm = 1.609;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*__________*");
            Console.ResetColor();
            
            Console.WriteLine(@"Olá usuário!
Esse programa converterá uma distância em Milhas para Quilômetros.");
            
            Console.Write("Entre com a medida em milhas: ");
            string MilhasDigitadas = Console.ReadLine();
            
            double MilhasDouble = Convert.ToDouble(MilhasDigitadas);
            Console.WriteLine("Eis o resultado:");
            Console.WriteLine($"{MilhasDouble * MilhasEmKm} Km");
            Console.WriteLine("Gratidão!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(";-P");
            Console.ResetColor();


        }
    }
}
