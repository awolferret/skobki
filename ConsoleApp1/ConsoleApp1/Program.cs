using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int depthCount = 0;
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == '(')
                {
                    depthCount++;
                    count++;
                }
                else if ((count > 0 && text[i] == ')'))
                {
                    count--;
                }
                //else if (text[i] == ')')
                //{
                    
                //}
            }

            if (count >= 0)
            {
                Console.WriteLine("Скобочная последвательность верна");
                Console.WriteLine($"Глубина {depthCount}");
            }
            else
            {
                Console.WriteLine("Последовательность не верна");
            }

            //if (opener > closer)
            //{
            //    result = closer;
            //    Console.WriteLine($"Результат глубины {result}");
            //}

            //else if (closer > opener)
            //{
            //    result = opener;
            //    Console.WriteLine($"Результат глубины {result}");
            //}

            //else
            //{
            //    result = opener;
            //    Console.WriteLine($"Результат глубины {result}");
            //}
        }
    }
}