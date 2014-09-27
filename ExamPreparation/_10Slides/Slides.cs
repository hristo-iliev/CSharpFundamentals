namespace _10Slides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Slides
    {
        private static string[,,] cube;
        public static void Main()
        {
            string[] vhod = Console.ReadLine().Split();

            int w = Convert.ToInt32(vhod[0]);
            int h = Convert.ToInt32(vhod[1]);
            int d = Convert.ToInt32(vhod[2]);

            cube = new string[w, h, d];

            for (int height = 0; height < h; height++)
            {
                string[] red = Console.ReadLine().Split('|');
                for (int depth = 0; depth < d; depth++)
                {
                    string kol = red[depth].Replace(")", String.Empty).Trim(new char[] { ' ' });
                    string[] zada4i = kol.Split(new char[] {'('}, StringSplitOptions.RemoveEmptyEntries);

                    for (int wigth = 0; wigth < w; wigth++)
                    {
                        cube[wigth, height, depth] = zada4i[wigth].Trim(new char[] { ' ' });
                    }
                }
            }

            string[] starter = Console.ReadLine().Split();

            int ballW = Convert.ToInt32(starter[0]);
            int ballD = Convert.ToInt32(starter[1]);
            int ballH = 0;

            string last = "";
            
            bool isBasket = false;
            while (true)
            {
                
                if (ballD >= d || ballD < 0 || ballW >= w || ballW < 0)
                {
                    Console.WriteLine("No");
                    break;
                }

                if (ballH >= h)
                {
                    Console.WriteLine("Yes");
                    break;
                }

                last = ballW.ToString() + " " + ballH.ToString() + " " + ballD.ToString();
 
                switch (cube[ballW,ballH, ballD])
                {
                    case "S L":
                        ballW--;
                        ballH++;
                        break;
                    case "S R":
                        ballW++;
                        ballH++;
                        break;
                    case "S B":
                        ballD--;
                        ballH++;
                        break;
                    case "S F":
                        ballD++;
                        ballH++;
                        break;
                    case "S FL":
                        ballD++;
                        ballW--;
                        ballH++;
                        break;
                    case "S FR":
                        ballD++;
                        ballW++;
                        ballH++;
                        break;
                    case "S BL":
                        ballD--;
                        ballW--;
                        ballH++;
                        break;
                    case "S BR":
                        ballD--;
                        ballW++;
                        ballH++;
                        break;
                    case "E":
                        h++;
                        break;
                    case "B":
                        isBasket = true;
                        break;
                    default:
                        StringBuilder x = new StringBuilder();
                        for (int i = 0; i < cube[ballW,ballH, ballD].Length; i++)
                        {
                            if (char.IsDigit(cube[ballW,ballH, ballD][i]))
                            {
                                x.Append(cube[ballW, ballH, ballD][i]);
                            }
                            else
                            {
                                ballW = Convert.ToInt32(x.ToString());
                                x.Clear();
                            }
                        }
                        ballD = Convert.ToInt32(x.ToString());
                        break;
                }

                if (isBasket)
                {
                    Console.WriteLine("No");

                    break; ;
                }
            }

            Console.WriteLine(last);
        }
    }
}
