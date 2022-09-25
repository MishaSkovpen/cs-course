using System;

namespace Lab4
{


    internal class Program
    {

        static void Main(string[] args)
        {
            const int N = 20;
            double[] m = new double[N];
            Random rand = new Random();
            // initialize array with random values
            Console.WriteLine("Масив з {0} елементів:", N);
            for (int i = 0; i < N; i++)
            {
                m[i] = rand.NextDouble();
                Console.WriteLine("m[{0}] = {1}", i, m[i].ToString());
            }

            double min = Math.Abs(m[0] - m[1]);

            int I = 0, J = 1;
            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                {
                    double next_min = Math.Abs(m[i] - m[j]);
                    if (next_min < min)
                    {
                        min = next_min;
                        I = i; J = j;
                    }
                }
            Console.WriteLine("Найближчі елементи масиву {0} та {1} (зі значеннями {2} та {3})", I, J, m[I].ToString(), m[J].ToString());

        }
    }
}