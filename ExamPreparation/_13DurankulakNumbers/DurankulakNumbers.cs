namespace _13DurankulakNumbers
{
    using System;
    using System.Collections.Generic;

    public class DurankulakNumbers
    {
        private static ulong res = 0;
        private static Stack<ulong> torba = new Stack<ulong>();
        private static List<char> upper = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static ulong Above168(string input)
        {
            ulong r = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                r += (ulong)(input[i] - 'A');
                i--;

                if (i >= 0)
                {
                    r += (ulong)(input[i] - 'a' + 1) * 26;
                }
            }

            return r;
        }

        public static void Calculating()
        {
            res += torba.Pop();
            int stepen = 1;

            while (torba.Count > 0)
            {
                res += (ulong)Math.Pow(168, stepen) * torba.Pop();
                stepen++;
            }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            ////string input = Console.ReadLine();

            Queue<string> mej = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (upper.Contains(input[i]))
                {
                    mej.Enqueue(input[i].ToString());
                }
                else
                {
                    mej.Enqueue(input[i].ToString() + input[i + 1].ToString());
                    i++;
                }
            }

            while (mej.Count > 0)
            {
                torba.Push(Above168(mej.Dequeue()));
            }

            Calculating();
            Console.WriteLine(res);
        }
    }
}
