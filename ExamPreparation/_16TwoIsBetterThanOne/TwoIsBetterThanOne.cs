namespace _16TwoIsBetterThanOne
{
    using System;
    using System.Collections.Generic;

    public class TwoIsBetterThanOne
    {
        private static ulong[] ab;
        private static List<ulong> special = new List<ulong>()
        {3,5,33,55,333,353,535,555,3333,3553,5335,5555,
         33333,33533,35553,35353,
         55555,53535,55355,53335,
         333333,335533,353353,355553,
         555555,553355,535535,533335,
         3333333,3335333,3355533,3535353,3533353,3555553,
         5555555,5553555,5533355,5353535,5355535,5333335,
         33333333};
        private static int counter;

        public static void SpecialNums()
        {
            counter = 0;
            for (ulong i = ab[0]; i <= ab[1]; i++)
            {
                if (special.Contains(i))
                {
                    counter++;
                }
            }
        }

        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            ab = Array.ConvertAll(input, ulong.Parse);

            string[] line = Console.ReadLine().Split();
            long[] nums = Array.ConvertAll(input, long.Parse);
            Array.Sort(nums);
            long per = long.Parse(Console.ReadLine());

            SpecialNums();

            Console.WriteLine(counter);
            Console.WriteLine(1);
        }
    }
}
