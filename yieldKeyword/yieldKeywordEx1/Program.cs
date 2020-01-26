using System;
using System.Collections;
using System.Collections.Generic;

namespace yieldKeywordEx1
{
     class Program
    {
        static void Main(string[] args)
        {
            foreach(int result in EvenNumbers(2,12))
            {
                Console.Write(result + " ");
            }

            foreach(int result in EvenNumbersWithYield(2,12))
            {
                Console.Write(result + " ");
            }


            Console.ReadKey();
        }

        public static IEnumerable<int> EvenNumbersWithYield(int lowerBound, int upperBound)
        {
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if(i % 2 == 0)
                    yield return i;
            }
        }

        public static IEnumerable<int> EvenNumbers(int lowerBound, int upperBound)
        {
            List<int> result = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if(i % 2 == 0)
                    result.Add(i);
            }

            return result;
        }
    }
}
