using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam()
            {
                Title = "C# Final Exam",
                Date = "1397/12/15",
                Questions = new Question[]
                {
                    new Question() {
                        RowNumber = 1,
                        Text = "Which One Is An OO Language?"
                    },
                    new Question() {
                        RowNumber = 2,
                        Text = "What is Interface Definition?"
                    },
                    new Question() {
                        RowNumber = 3,
                        Text = "What is the diffence between interface and abstract class?"
                    },
                    new Question() {
                        RowNumber = 4,
                        Text = "What is the main usage of functions?"
                    }
                }
            };

            foreach (var question in exam)
            {
                Console.WriteLine(question);
            }

            Console.ReadKey();
        }
    }
}
