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
                    count++;

                    if (depthCount < count)
                    {
                        depthCount = count;
                    }
                }
                else if ((text[i] == ')'))
                {
                    count--;
                    if (count < 0)
                    {
                        break;
                    }
                }
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
        }
    }
}