using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double get_resistor(int resistor_number)
        {
            Console.Write("Введіть значення опору резистору {0:D} в омах: ", resistor_number);
            double resistance = double.Parse(Console.ReadLine());
            return resistance;
        }
        static void Main(string[] args)
        {
            const int res_num = 3;

            double[] resistors = new double[res_num];

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int i = 0; i < res_num; i++)
            {
                resistors[i] = get_resistor(i+1);
            }

            Console.WriteLine("Опір електричного ланцюга з {0:F} послідовно з'єднаних резисторів з опорами ", res_num);
            double total_resistance = 0;
            //При послідовному з'єднанні повний опір кола дорівнює сумі опорів окремих провідників
            for (int i = 0; i < res_num; i++)
            {
                total_resistance += resistors[i];
                Console.WriteLine("{0:F} Ом,", resistors[i]);
            }
            Console.WriteLine("складає {0:F} Ом", total_resistance);

        }
    }
}