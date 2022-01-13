using System;
using System.Numerics;

namespace BOJ_16428
{
    internal static class MainApp
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var ab = line.Split(' ');
            var a = BigInteger.Parse(ab[0]);
            var b = BigInteger.Parse(ab[1]);

            var q = a / b;
            var r = a % b;
            if (r < 0)
            {
                if (0 < b)
                {
                    r += b;
                    q -= 1;
                }
                else
                {
                    r -= b;
                    q += 1;
                }
            }

            Console.WriteLine(q);
            Console.WriteLine(r);
        }
    }
}