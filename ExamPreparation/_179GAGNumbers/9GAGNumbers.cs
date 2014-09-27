namespace _179GAGNumbers
{
    using System;
    using System.Collections.Generic;

	public class Program
	{
		public static ulong Stepen(ulong stepen)
		{			
			if (stepen == 0)
			{
				return 1;
			}

			ulong res = 1;
			for (ulong i = 0; i < stepen; i++)
			{
				res *= 9;
			}

			return res;
		}

		public static void Main()
		{
			string input = Console.ReadLine();
			input = input.Trim(new char[] {' '});

			ulong res = 0;
			Stack<ulong> nums = new Stack<ulong>();

			for (int i = 0; i < input.Length; )
			{
				switch (input[i])
				{
					case '-':
						nums.Push(0);
						i += 2;
						break;
					case '*':
						if (input[i+1] == '*' )
						{
							nums.Push(1);
							i += 2;
						}
						else
						{
							nums.Push(6);
							i += 4;
						}
						break;
					case '!':
						if (input[i+1] == '-')
						{
							nums.Push(5);
							i += 2;
						}
						else if (input[i+2] == '!')
						{
							nums.Push(2);
							i += 3;
						}
						else
						{
							nums.Push(8);
							i+=6;
						}
						break;
					case '&':
						if (input[i+1] == '&')
						{
							nums.Push(3);
							i+=2;
						}
						else if (input[i+1] == '-')
						{
							nums.Push(4);
							i+=2;
						}
						else
						{
							nums.Push(7);
							i += 3;
						}
						break;
					default:
						break;
				}
			}
			//input = input.Replace("!!**!-", "8");
			//input = input.Replace("*!!!", "6");
			//input = input.Replace("!!!", "2");
			//input = input.Replace("&*!", "7");
			//input = input.Replace("&&", "3");
			//input = input.Replace("&-", "4");
			//input = input.Replace("**", "1");
			//input = input.Replace("!-", "5");
			//input = input.Replace("-!", "0");
			ulong stepen = 0;
			while (nums.Count != 0)
			{
				
				res += Stepen(stepen) * nums.Pop();
				stepen++;
			}

			Console.WriteLine(res);
		}
	}
}
