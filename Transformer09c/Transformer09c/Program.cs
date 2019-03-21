using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer09c
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please input number for x-axis");
                float x = float.Parse(Console.ReadLine());
                Console.WriteLine("Please input number for x-axis");
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine($"You've hit for {EvaluateDartThrow(x,y)} points.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int EvaluateDartThrow(float x, float y)
        {


            float distance = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (distance > 10)
            {
                return 0;
            }
            else if (distance > 5)
            {
                return 1;
            }
            else if (distance > 1)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
