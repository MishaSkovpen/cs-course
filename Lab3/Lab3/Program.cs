using System;

namespace Lab3
{

    public struct Cage
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Cage(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    internal class Program
    {

        static Cage get_cage(string cage_name)
        {
            int x, y;
            while (true)
            {
                Console.Write("Введіть {0} клітинку координатами Х, У зі значеннями від 1 до 8 через кому : ", cage_name);
                string[] input = Console.ReadLine().Split(',');
                if (int.TryParse(input[0], out x) &
                    int.TryParse(input[1], out y) &
                    x >= 1 & x <= 8 &
                    y >= 1 & y <= 8)
                    break;
            }
            return new Cage(x, y);
        }
        static void Main(string[] args)
        {
            Cage start_cage, finish_cage;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            start_cage = get_cage("початкову");
            finish_cage = get_cage("кінцеву");

            Console.WriteLine("слон за один хід може перейти з {0},{1} до {2},{3}: ", start_cage.X, start_cage.Y, finish_cage.X, finish_cage.Y);
            Console.WriteLine(Math.Abs(start_cage.X - finish_cage.X) == Math.Abs(start_cage.Y - finish_cage.Y));

        }
    }
}