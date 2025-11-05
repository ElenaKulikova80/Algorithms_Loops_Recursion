using System;

namespace LoopsAndRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // №1
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x < y) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№2
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x == y) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№3
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x + y == 24) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№4
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x + y < 30) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№5
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x * 2 == y || x * 2 + 1 == y) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№6
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x < 10 || y < 10) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№7
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x > 15 && y > 15) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№8
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x * y == 0) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№9
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((y > x + 10 || x > y + 10) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№10
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((y > x && y <= 2 * x + 1) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№11
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(((x == 1 || x == 23) || (y == 1 || y == 23)) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№13
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x + y > 19 && x + y < 29) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№18
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((((x == 0 && y != 0) || x == 1 || (y == 0 && x != 0) || y == 1)) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№19
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write(((x == 0 || x == 24) || (y == 0 || y == 24)) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№20
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((((x == 0 || x % 2 == 0) && (y == 0 || y % 2 == 0)) || (x % 2 != 0 && y % 2 != 0)) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№21
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x == 0 || y == 0 || y % (x + 1) == 0) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //№24
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                    Console.Write((x == y || x + y == 24) ? "# " : ". ");
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
