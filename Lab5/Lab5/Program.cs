using Microsoft.VisualBasic;
using System;

namespace Lab5
{

    class RandomMatrix
    {
        public int[,] matrix;
        public int width;
        public int height;
        public RandomMatrix(int width, int height)
        {
            this.width = width;
            this.height = height;
            matrix = new int[width, height];
            Random rnd = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++) { 
                    matrix[i, j] = rnd.Next(100);
                }
            }
        }
        public int MonotonicRowsNumber ()
        {
            int monotonic_count = 0;
            if (width > 1) {
                for (int i = 0; i < height; i++)
                {
                    bool increasing = this.matrix[0, i] <= this.matrix[1, i];
                    bool is_monotonic = true;
                    for (int j = 1; j < width - 1; j++) {
                        if ((increasing & this.matrix[j, i] > this.matrix[j + 1, i]) | (this.matrix[j, i] < this.matrix[j + 1, i]))
                        {
                            is_monotonic = false;
                            break;
                        }
                    }
                    if (is_monotonic) monotonic_count++;
                }
            }
            return monotonic_count;
        }

        public int MonotonicColumnsNumber()
        {
            int monotonic_count = 0;
            if (height > 1)
            {
                for (int i = 0; i < width; i++)
                {
                    bool increasing = this.matrix[i, 0] <= this.matrix[i, 1];
                    bool is_monotonic = true;
                    for (int j = 1; j < height - 1; j++)
                    {
                        if ((increasing & this.matrix[i, j] > this.matrix[i, j + 1]) | (this.matrix[i, j] < this.matrix[i, j+1]))
                        {
                            is_monotonic = false;
                            break;
                        }
                    }
                    if (is_monotonic) monotonic_count++;
                }
            }
            return monotonic_count;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            RandomMatrix m = new RandomMatrix(5, 3);

            for (int i = 0; i < m.height; i++)
            {
                for (int j = 0; j < m.width; j++)
                {
                    Console.Write(string.Format("{0} ", m.matrix[j, i]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.WriteLine("1) кількість рядків, елементи яких монотонно  зростають (спадають): {0}", m.MonotonicRowsNumber());
            Console.WriteLine("1) кількість стовпчиків, елементи яких монотонно  зростають (спадають): {0}", m.MonotonicColumnsNumber()); 

        }
    }
}