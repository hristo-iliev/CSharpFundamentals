namespace CSPermutation
{
    using System;

    public class Program
    {
        public static void SortChar(char[] buffer, int len)
        {
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (buffer[j] > buffer[j + 1])
                    {
                        char temp = buffer[j];
                        buffer[j] = buffer[j + 1];
                        buffer[j + 1] = temp;
                    }
                }
            }
        }

        public static bool NextPermuation(char[] p, int len)
        {
            for (int k = len - 1; k > 0; k--)
            {
                if (p[k - 1] >= p[k])
                {
                    continue;
                }                    
                else
                {
                    if (k <= len - 3)
                    {
                        char newchar = p[k - 1];
                        int anchor = -1;
                        for (int j = len - 1; j >= k; j--)
                        {
                            if (newchar < p[j])
                            {
                                anchor = j;
                                break;
                            }
                        }

                        if (anchor == -1)
                        {
                            return false;
                        }
                            
                        char ch = p[k - 1];
                        p[k - 1] = p[anchor];
                        p[anchor] = ch;

                        char[] tbuffer = new char[len - k];
                        for (int m = 0; m < len - k; m++)
                        {
                            tbuffer[m] = p[k + m];
                        } 
                           
                        SortChar(tbuffer, len - k);
                        for (int n = 0; n < len - k; n++)
                        {
                            p[k + n] = tbuffer[n];
                        }
                            
                        return true;
                    }
                    else
                    {
                        char[] tempptr = new char[3];
                        tempptr[0] = p[p.Length - 3];
                        tempptr[1] = p[p.Length - 2];
                        tempptr[2] = p[p.Length - 1];

                        int count = 3;
                        for (int i = count - 1; i > 0; i--)
                        {
                            if (tempptr[i - 1] >= tempptr[i])
                            {
                                continue;
                            }
                            else
                            {
                                if (i <= count - 2)
                                {
                                    if (tempptr[i + 1] > tempptr[i - 1])
                                    {
                                        char ch = tempptr[i + 1];
                                        tempptr[i + 1] = tempptr[i];
                                        tempptr[i] = tempptr[i - 1];
                                        tempptr[i - 1] = ch;
                                    }
                                    else
                                    {
                                        char ch = tempptr[i - 1];
                                        tempptr[i - 1] = tempptr[i];
                                        tempptr[i] = tempptr[i + 1];
                                        tempptr[i + 1] = ch;
                                    }
                                }
                                else
                                {
                                    char ch = tempptr[i];
                                    tempptr[i] = tempptr[i - 1];
                                    tempptr[i - 1] = ch;
                                }

                                p[p.Length - 3] = tempptr[0];
                                p[p.Length - 2] = tempptr[1];
                                p[p.Length - 1] = tempptr[2];
                                return true;
                            }
                        }

                        return false;
                    }
                }
            }

            return false;
        }

        public static bool IsCool(char[] buffer)
        {
            bool ok = true;

            for (int i = 1; i < buffer.Length; i++)
            {
                if (buffer[i] == buffer[i - 1])
                {
                    ok = false;
                    break;
                }
            }

            return ok;
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] buffer = s.ToCharArray();
            Array.Sort(buffer);
            //// sortchar(buffer, buffer.Length); //// use it only if you require

            int count = 0;
            while (true)
            {
                if (IsCool(buffer))
                {
                    count++;
                }

                if (NextPermuation(buffer, buffer.Length) == false)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
