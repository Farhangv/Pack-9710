using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCharachterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.BackgroundColor = ConsoleColor.Blue;
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(x++, y);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(x--, y);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(x, y++);
                        Console.Write(" ");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(x, y--);
                        Console.Write(" ");
                        break;

                }
            }
        }
    }
}
