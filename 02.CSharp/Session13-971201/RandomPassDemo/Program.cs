using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPassDemo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write("Password Length:");
            var length = int.Parse(Console.ReadLine());
            string randomPass = string.Empty;
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                var charType = r.Next(0, 3);
                switch (charType)
                {
                    case 0:
                        randomPass += (char)r.Next(65,91);//Upper
                        break;
                    case 1:
                        randomPass += (char)r.Next(97,123);//Lower
                        break;
                    case 2:
                        randomPass += r.Next(0, 10).ToString();
                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(randomPass);
            //TODO: Copy To clipboard
            Clipboard.SetText(randomPass);
            Console.ReadKey();
        }
    }
}
