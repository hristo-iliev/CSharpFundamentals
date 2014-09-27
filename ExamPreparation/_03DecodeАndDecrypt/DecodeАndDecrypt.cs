////Variant 1 (2013-09-14, Morning)

namespace _03DecodeАndDecrypt
{
    using System;
    using System.Text;

    public class DecodeАndDecrypt
    {
        public static string GetCyperLength(string input)
        {
            string lenght = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    lenght += input[i];
                }
                else
                {
                    break;
                }
            }

            var res = new StringBuilder();
            for (int i = lenght.Length - 1; i >= 0; i--)
            {
                res.Append(lenght[i]);
            }

            return res.ToString();
        }

        public static string Decrypt(string input)
        {
            var result = new StringBuilder();

            string num = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    num += input[i];
                }
                else
                {
                    if (num != string.Empty)
                    {
                        result.Append(input[i], Convert.ToInt32(num));
                        num = string.Empty;
                    }
                    else
                    {
                        result.Append(input[i]);
                    }
                }
            }

            return result.ToString();
        }

        public static void GetMasage(string message, string cyper)
        {
            var result = new StringBuilder(message);

            int bigger = Math.Max(message.Length, cyper.Length);

            int messageInx = 0;
            int cyperInx = 0;
            int steps = 0;

            while (steps != bigger)
            {
                if (messageInx == message.Length)
                {
                    messageInx = 0;
                }

                if (cyperInx == cyper.Length)
                {
                    cyperInx = 0;
                }

                result[messageInx] = (char)(((result[messageInx] - 'A') ^ (cyper[cyperInx] - 'A')) + 'A');

                messageInx++;
                cyperInx++;
                steps++;
            }

            Console.WriteLine(result.ToString());
        }

        public static void Main()
        {
            string input = Console.ReadLine();

            ////Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher)

            string cyperLenghtTXT = GetCyperLength(input);

            int cyperLength = Convert.ToInt32(cyperLenghtTXT);

            string current = input.Substring(0, input.Length - cyperLenghtTXT.Length);

            string decrypted = Decrypt(current);

            string message = decrypted.Substring(0, decrypted.Length - cyperLength);
            string cyper = decrypted.Substring(message.Length);

            GetMasage(message, cyper);
        }
    }
}
