using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double a(int k)
        {
            double k_sq = Math.Pow(k, 2);
            double denom = k_sq + 3;
            double nom = (k % 2 == 1 ? -1 : 1) * k_sq - 1;

            return nom / denom;
        }
        static void Main(string[] args)
        {
            int nn;
            int nk = -1;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            do {
                Console.Write("Введіть значення nn (ціле, більше або дорівнює 0): ");
                nn = int.Parse(Console.ReadLine());
                if (nn < 0)
                    Console.WriteLine("nn повинно бути більше 0");
            } while (nn < 0);

            for (; nk < nn;) {
                Console.Write("Введіть значення nk (ціле, більше або дорівнює {0:D}): ", nn);
                nk = int.Parse(Console.ReadLine());
                if (nk >= nn)
                    break;
                Console.WriteLine("nn повинно бути більше або дорівнює {0:D}): ", nn);
            }

            double sum = 0;
            for (int k = nn; k <=nk; k++)
            {
                sum += a(k);
            }
            Console.WriteLine("Сума a(k) де k від {0:D} до {1:D} складає {2:F}", nn, nk, sum);

        }
    }
}
