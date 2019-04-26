using System;

namespace PopQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++) Console.WriteLine((i % 7 == 0 && i % 9 == 0) ? "PopQuiz" : i % 7 == 0 ? "Pop" : i % 9 == 0 ? "Quiz" : i.ToString());
            //Longway();
            Console.ReadLine();
        }

        public static void Longway()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 9 == 0)
                {
                    Console.WriteLine("PopQuiz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Pop");
                }
                else if (i % 9 == 0)
                {
                    Console.WriteLine("Quiz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
