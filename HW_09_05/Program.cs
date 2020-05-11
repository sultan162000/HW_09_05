using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_09_05
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 123456;
            var n = (from p in number.ToString().ToCharArray().Reverse()
                     select p);
            foreach (var item in n)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();


            int[] num = { 36, 2, 3, 26, 5, 6, 0, 15, 9, 101, -11, -12, -13, -14, -15 };
            var countNum = (from p in num
                            where p >= 0
                            select p).Count();
            var sum = (from p in num
                       where p < 0
                       select p).Sum();
            int[] sumNum = { countNum, sum };
            foreach (var item in sumNum)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();


            string[] str = { "Telescopes", "Glasses", "Eyes", "Monocles" };

            var s = (from p in str
                     orderby p.Length
                     select p);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            int[] u = { 1, 1, 1, 3, 1, 1 };
            var Un = (from p in u
                      select p).Distinct();
            foreach (var item in Un)
            {
                if (item == 1) continue;
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
        
    }
}
