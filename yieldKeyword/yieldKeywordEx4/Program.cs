using System;
using System.Collections.Generic;


namespace yieldKeywordEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string day in Days())
            {
                Console.WriteLine(day);
            }
        }

        static IEnumerable<string> Days()
        {
            
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
            yield return "Thursday";
            yield return "Friday";
            yield break;
        }
    }
}
