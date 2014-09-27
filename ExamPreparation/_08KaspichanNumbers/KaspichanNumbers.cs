using System;
using System.Collections.Generic;
using System.Text;

public class KaspichanNumbers
{
    private static StringBuilder res = new StringBuilder();
    
    public static string Above256(Stack<ulong> result)
    {
        while (result.Count != 0)
        {
            ulong num = result.Pop();
            ulong count = 0;
            while (num > 25)
            {
                num -= 26;
                count++;
            }

            if (count > 0)
            {
                res.Append((char)(count + 'a' - 1));
            }

            res.Append((char)(num + 'A'));
        }

        return res.ToString();
    }

    public static void Main()
    {
        ////ulong input = 100000;
        ulong input = ulong.Parse(Console.ReadLine());

        Stack<ulong> result = new Stack<ulong>();
        if (input == 0)
        {
            Console.WriteLine('A');
            return;
        }

        while (input != 0)
        {
            result.Push(input % 256);
            input /= 256;
        }

        Console.WriteLine(Above256(result));
    }
}
