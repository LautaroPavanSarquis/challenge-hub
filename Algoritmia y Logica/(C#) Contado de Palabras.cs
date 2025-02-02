using System;
using System.Collections.Generic;

class Program
{
    static void wordCount(string texto)
    {
        Dictionary<string, int> palabraContada = new Dictionary<string, int>();

        // Limpiar el string
        string[] palabras = texto.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        //Recorrer 
        foreach (string palabra in palabras)
        {
            if (palabraContada.ContainsKey(palabra))
            {
                palabraContada[palabra]++;
            }
            else
            {
                  palabraContada.Add(palabra, 1);
            }
        }

        // Mostrar
        foreach (var entry in palabraContada)
        {
            Console.WriteLine($"Palabra: {entry.Key}, Contador: {entry.Value}");
        }
    }

    static void Main(string[] args)
    {
        string text = "The Rolling Stones are a rock band from London. " +
            "Formed in 1962, they created hits like 'Satisfaction'. " +
            "Mick Jagger and Keith Richards defined rock music and influenced generations.";

        wordCount(text);
    }
}

