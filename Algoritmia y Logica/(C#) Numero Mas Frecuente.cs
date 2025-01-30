using System;
using System.Collections.Generic;

public class Program
{
    static void numberFrequency(int[] nums)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        // Contar frecuencias
        for (int i = 0; i < nums.Length; i++)
        {
            if (counts.ContainsKey(nums[i]))
            {
                counts[nums[i]]++;
            }
            else
            {
                counts.Add(nums[i], 1);
            }
        }

        // Encontrs número con mayor frecuencia
        int maxFrequency = 0;
        int numberWithMaxFrequency = 0;

        foreach (var entry in counts)
        {
            if (entry.Value > maxFrequency)
            {
                maxFrequency = entry.Value;
                numberWithMaxFrequency = entry.Key;
            }
        }

        // Mostrar
        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine($"Número más frecuente: {numberWithMaxFrequency}, aparece {maxFrequency} veces.");
    }

    public static void Main(string[] args)


    {
        int[] numeros = { 3, 1, 4, 1, 2, 3, 3, 4, 4, 4, 5 };
        numberFrequency(numeros);
    }
}
