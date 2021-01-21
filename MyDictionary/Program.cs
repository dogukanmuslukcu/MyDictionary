using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.AddWords("Scholl", "Okul");
            dictionary.AddWords("Unforgettable", "Unutulmaz");

            foreach (var item in dictionary.Words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
