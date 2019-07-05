using System;
using System.Collections.Generic;

namespace fibGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> fibList = fibGen(n);

            fibList.ForEach(Console.WriteLine);

        }

        private static List<int> fibGen(int n)
        {
            List<int> fibs = new List<int>();

            int i = 0;
            int j = 1;

            while (fibs.Count < n)
            {

                int place = j;

                int temp = i + j;

                fibs.Add(temp);

                i = place;
                j = temp;

            }
            return fibs;
        }
    }
}
