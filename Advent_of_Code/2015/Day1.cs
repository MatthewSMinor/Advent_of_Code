namespace Advent_of_Code._2015
{
    public static class Day1
    {
        public static void Part1()
        {
            string input = File.ReadAllText("../../../2015/Day1Input.txt");

            var floor = 0;

            foreach (var c in input)
            {
                switch(c)
                {
                    case '(': floor++; break;
                    case ')': floor--; break;
                }
            }

            Console.WriteLine("D1P1: " + floor);
        }

        public static void Part2()
        {
            string input = File.ReadAllText("../../../2015/Day1Input.txt");

            var position = 1;
            var floor = 0;

            foreach (var c in input)
            {
                switch (c)
                {
                    case '(': floor++; break;
                    case ')': floor--; break;
                }
                if (floor == -1)
                {
                    Console.WriteLine("D1P2: " + position); break;
                }
                position++;
            }

        }
    }
}
