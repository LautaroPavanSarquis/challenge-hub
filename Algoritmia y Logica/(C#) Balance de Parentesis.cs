using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void balanceDeParéntesis(string texto)
        {
            int count = 0; //cuenta "(" ")"

            foreach (char caracter in texto)
            {
                switch (caracter)
                {
                    case '(':
                        count++;
                        break;

                    case ')':
                        count--;

                        if (count < 0)
                        {
                            Console.WriteLine("Los parentesis no estan balanceados"); 
                            return;
                        }
                        
                        break;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Los parentesis estan balanceados");
            }
            else
            {
                Console.WriteLine("Los parentesis no estan balanceados");
            }
        }



        static void Main(string[] args)
        {
            balanceDeParéntesis("            ");
            balanceDeParéntesis(")(");
            balanceDeParéntesis("(Este es un (ejemplo) de texto con (paréntesis) balanceados).");
            balanceDeParéntesis("(Este (texto no) está balanceado porque falta un cierre (.            ");
        }
    }
}