using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxDeo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBox(20, 20, 25, 8, ConsoleColor.Blue);
            DrawBox(35, 5, 15, 8, ConsoleColor.Red);
            Console.ReadKey();
        }

        static void DrawBox(int left, int top, int width, int height, ConsoleColor color)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(left, top);
            Console.BackgroundColor = color;
            //Console.WriteLine("      ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(left, top + i);
            }

        }
    }
}
