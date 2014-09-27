namespace _09GreedyDwarf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GreedyDwarf
    {
        static long bestCoins = long.MinValue;
        static int[] valley;
        static bool[] valleyVisited;

        static void RazcukvaneNaValley(int[] pattern)
        {
            long currentCoins = 0;

            int position = 0;

            for (int i = 0; i < pattern.Length; )
            {
                if (position >= valley.Length ||  position < 0 || valleyVisited[position] == true)
                {
                    break;
                }
                else
                {
                    valleyVisited[position] = true;
                    currentCoins += valley[position];
                    position += pattern[i];
                }

                i++;

                if (i == pattern.Length)
                {
                    i = 0;
                }
            }

            if (currentCoins > bestCoins)
            {
                bestCoins = currentCoins;
            }
        }
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            valley = Array.ConvertAll(input, int.Parse);
            int countPatterns = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPatterns; i++)
            {
                string[] patternIn = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                int[] pattern = Array.ConvertAll(patternIn, int.Parse);
                valleyVisited = new bool[valley.Length];

                RazcukvaneNaValley(pattern);
            }

            Console.WriteLine(bestCoins);
        }
    }
}
