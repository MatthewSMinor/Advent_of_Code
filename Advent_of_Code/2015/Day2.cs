namespace Advent_of_Code._2015
{
    public static class Day2
    {
        public static void Part1()
        {
            var input = File.ReadAllLines("../../../2015/Day2Input.txt");

            var total = 0;
            foreach (var line in input)
            {
                var dimensions = line.Split('x');
                var l = Int32.Parse(dimensions[0]);
                var w = Int32.Parse(dimensions[1]);
                var h = Int32.Parse(dimensions[2]);

                var sides = new int[] { (l * w), (w * h), (h * l) };

                total += sides.Min(i => i);
                foreach (var side in sides)
                {
                    total += (2*side);
                }
            }

            Console.WriteLine("D2P1: " + total);
        }

        public static void Part2()
        {
            var input = File.ReadAllLines("../../../2015/Day2Input.txt");

            var total = 0;
            foreach (var line in input)
            {
                var dimensions = line.Split('x');

                var d = dimensions.Select(i => Convert.ToInt32(i)).ToArray();

                Array.Sort(d);

                var feetOfRibbon = (2 * d[0]) + (2 * d[1]);
                var feetForBow = d.Aggregate(1, (a, b) => a*b);
                total += (feetOfRibbon + feetForBow);
            }

            Console.WriteLine("D2P2: " + total);
        }
    }
}
