using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumbers
    {
        public void PrimeNumber()
        {
            int count = 0;
            int ctr;
            Console.WriteLine("Enter initial value: ");
            int initialNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end value: ");
            int endNum = Convert.ToInt32(Console.ReadLine());

            for (int i = initialNum; i <= endNum; i++)
            {
                ctr = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && i != 1)
                {
                    Console.WriteLine($"{i} is a Prime Number");
                    count++;
                }
            }
            Console.WriteLine($"Total Prime Numbers are {count}");
        }
    }
}
