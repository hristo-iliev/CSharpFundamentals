////2013-09-14_Evening

namespace _05EncodeAndEncrypt
{
    using System;
    using System.Text;

    public class EncodeAndEncrypt
    {
        public static string Encrypt(string message, string cyper)
        {
            var result = new StringBuilder(message);

            int lenght = Math.Max(message.Length, cyper.Length);
            int steps = 0;
            int messageInx = 0;
            int cyperInx = 0;

            while (steps != lenght)
            {
                if (messageInx == message.Length)
                {
                    messageInx = 0;
                }

                if (cyperInx == cyper.Length)
                {
                    cyperInx = 0;
                }

                result[messageInx] = (char)(((result[messageInx] - 'A') ^ cyper[cyperInx] - 'A') + 65);

                messageInx++;
                cyperInx++;
                steps++;
            }

            return result.ToString();
        }

        public static string Encode(string encrypted)
        {
            var current = new StringBuilder();
            var result = new StringBuilder();

            current.Append(encrypted[0]);
            bool isKLast = false;

            for (int i = 1; i < encrypted.Length; i++)
            {
                isKLast = false;
                while (i != encrypted.Length && encrypted[i] == encrypted[i - 1])
                {
                    current.Append(encrypted[i]);
                    i++;
                }

                switch (current.Length)
                {
                    case 1:
                        result.Append(current[0]);
                        break;
                    case 2:
                        result.Append(current[0]);
                        result.Append(current[0]);
                        break;
                    default:
                        result.Append(current.Length);
                        result.Append(current[0]);
                        break;
                }

                if (i != encrypted.Length)
                {                  
                    current.Clear();
                    current.Append(encrypted[i]);
                    isKLast = true;
                }
            }

            if (isKLast)
            {
                result.Append(current[0]);
            }

            return result.ToString();
        }

        public static void Main()
        {
            string message = Console.ReadLine();
            string cyper = Console.ReadLine();

            ////Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
            string encrypted = Encrypt(message, cyper) + cyper;
            string encoded = Encode(encrypted) + cyper.Length.ToString();

            Console.WriteLine(encoded);
        }
    }
}
