using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3(10000);
            Task4(99);
        }

        static void Task3(int N)
        {
            int sum;

            for (int i = 1; i < N; i++)
            {
                sum = 0;

                for (int y = 1; y <= i / 2 + 1; y++)
                {
                    if (i % y == 0)
                        sum += y;

                }

                if (sum == i)
                    Console.WriteLine(i);
            }
        }
       static void Task4(int A)
        {

            for (int a = 1; a < 100; a++)
            {
                if (a % 3 == 1)
                    if (a % 4 == 2)
                        if (a % 5 == 3)
                            if (a % 6 == 4)
                                Console.WriteLine(a);
            }

        }

    }
}
