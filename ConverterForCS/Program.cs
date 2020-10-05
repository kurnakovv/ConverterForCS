using System;
using System.Linq;

namespace ConverterForCS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Q: Склеить слова в одно слово.");
                Console.WriteLine("W: Разделить слово в несколько слов.");    
                
                ConsoleKeyInfo inputSwitch = Console.ReadKey();
                
                Console.WriteLine();
                Console.Clear();

                switch (inputSwitch.Key)
                {
                    case ConsoleKey.Q:
                        Console.Write("Введите строку для склеивания : ");
                        string s = Console.ReadLine();
                        Console.Clear();
                        s.Split(' ')
                         .ToList()
                         .ForEach(i => {
                             if (!String.IsNullOrEmpty(i))
                             {
                                 i = i.Trim();
                                 Console.Write(i.Remove(1)
                                                 .ToUpper() + i.Substring(1) + "");
                             }
                         });
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case ConsoleKey.W:
                        Console.Write("Введите строку для разделения: ");
                        string mystring = Console.ReadLine();
                        Console.Clear();
                        for (int i = 0; i < mystring.Length; i++)
                        {
                            // Checks if a letter is capitalized or not
                            if (char.IsUpper(mystring, i))
                                Console.Write(" ");
                            Console.Write(mystring[i]);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
