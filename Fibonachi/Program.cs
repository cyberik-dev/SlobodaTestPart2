using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + FibonachiArray(N));
        }

        static int FibonachiArray(int N)
        {
            int result = 0;
            int current =0;
            int previous = 1;
           

            for(int i=0; i <N; i++)
            {
                if(N == 1)
                {
                    result = 0;
                    break;
                }
                result = previous + current;


                previous = current;
                current = result;
            }
            

            return result;
        }
    }
}

