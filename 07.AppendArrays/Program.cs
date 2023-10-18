using System;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> symbols = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string sequence = arrays[i];
                string[] array = sequence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                symbols.AddRange(array);
            }

            Console.WriteLine(string.Join(" ", symbols));
        }
    }
}