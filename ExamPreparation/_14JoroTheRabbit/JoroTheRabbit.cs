namespace _14JoroTheRabbit
{
    using System;
    
    public class JoroTheRabbit
    {
        private static int[] valley;        
        private static int bestSteps = 0;

        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            valley = Array.ConvertAll(input, int.Parse);            

            for (int start = 0; start < valley.Length; start++)
            {
                for (int st = 1; st < valley.Length; st++)
                {                    
                    int curSteps = 1;
                    int sta = start;
                    int val = valley[sta];

                    while (true)
                    {
                        if (sta + st >= valley.Length)
                        {
                            sta = sta + st - valley.Length;
                        }
                        else
                        {
                            sta += st;
                        }
                        
                        if (valley[sta] > val)
                        {
                            curSteps++;
                            val = valley[sta];
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (curSteps > bestSteps)
                    {
                        bestSteps = curSteps;
                    }
                }
            }

            Console.WriteLine(bestSteps);
        }
    }
}
