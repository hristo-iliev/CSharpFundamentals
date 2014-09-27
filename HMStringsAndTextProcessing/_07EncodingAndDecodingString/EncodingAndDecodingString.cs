//// Write a program that encodes and decodes a string using given encryption key (cipher).
//// The key consists of a sequence of characters. The encoding/decoding is done by performing
//// XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//// the second – with the second, etc. When the last key character is reached, the next is the first.

namespace _07EncodingAndDecodingString
{
    using System;
    using System.Text;

    public class EncodingAndDecodingString
    {
        public static string Encoding(string text, string key)
        {
            StringBuilder result = new StringBuilder();

            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }

                result.Append((char)(text[i] ^ key[keyIndex]));

                keyIndex++;
            }

            return result.ToString();
        }

        static string Decoding(string code, string key)
        {
            StringBuilder result = new StringBuilder();

            int keyIndex = 0;

            for (int i = 0; i < code.Length; i++)
            {
                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }

                result.Append((char)(code[i] ^ key[keyIndex]));

                keyIndex++;
            }

            return result.ToString();
        }
        static void Main()
        {
            string text = "Some Text, Oh My God Text, La-la";
            string key = "4i4o";

            string encoded = Encoding(text, key);

            Console.WriteLine("Encoding:");
            Console.WriteLine(encoded);

            Console.WriteLine(new string('-', 40));

            string decoded = Decoding(encoded, key);

            Console.WriteLine("Decoding:");
            Console.WriteLine(decoded);
        }
    }
}
