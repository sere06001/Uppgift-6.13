using System;
using System.Collections.Generic;
namespace uppgift6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv korten: ");
            string a = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Du har {Poäng(a)} poäng");
            Console.ReadKey();
        }
        static int Poäng(string a)
        {
            string[] b = a.Split();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var kort in b)
            {
                int tal = int.Parse(kort);
                if (dic.ContainsKey(tal))
                {
                    dic[tal]++;
                }
                else
                {
                    dic[tal] = 1;
                }
            }

            int summa = 0;
            foreach (var kort in dic)
            {
                summa += (int)Math.Pow(kort.Key, kort.Value);
            }
            return summa;
        }
    }
}