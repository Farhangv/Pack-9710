using System;

//namespace FirstCSharpApp.MainProgram.FirstPart
namespace FirstCSharpApp
{
    namespace MainProgram
    {
        class Program
        {
            static void Main()
            {
                {

                }
                //System.Console.WriteLine("Hello");
                Console                         .WriteLine("Hello");
                //System.Text.RegularExpressions.Regex
                /*
                 * این
                 * یک 
                 * توضیحات چند خطی
                 * است
                 */

                Sum(10, 20);
                Console
                    
                    .ReadKey();
            }
            /// <summary>
            /// این یک تابع برای جمع بستن دو عدد صحیح است
            /// </summary>
            /// <param name="x">عدد اول صحیح</param>
            /// <param name="y">عدد دوم صحیح</param>
            /// <returns>جمع دو عدد</returns>
            public static int Sum(int x, int y)
            {
                return x + y;
            }
        }
    }
}
