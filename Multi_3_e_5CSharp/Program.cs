using System;

namespace Multi_3_e_5CSharp
{
    class Program
    {


        static int sumn(int n, int d)
        {

            n = n / d;

            var r = d * n * (n + 1); // 2

            r = r / 2;

            return r;
        }



        static void Main(string[] args)
        {

            int a = 3;
            int b = 5;

            Console.Write("Valor de t: ");

            var t = int.Parse(Console.ReadLine());

            for (var i = 1; i <= t; i++)
            {
                Console.Write("Valor de n / " + i.ToString() + ": ");

                var n = int.Parse(Console.ReadLine());
                var s = sumn(n - 1, a) + sumn(n - 1, b) - sumn(n - 1, a * b);

                Console.WriteLine(s);
            }

        }
    }
}
