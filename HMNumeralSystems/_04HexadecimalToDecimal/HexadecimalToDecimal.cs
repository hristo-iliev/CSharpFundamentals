//// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

public class HexadecimalToDecimal
{
	public static int ConvertHexadecimalToDecimal(string hexNum)
	{
		int result = 0;

		for (int i = 0; i < hexNum.Length; i++)
		{
			switch (hexNum[i])
			{
				case 'A':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length- (i+1)) ));
					break;
				case 'B':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));
					break;
				case 'C':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));
					break;
				case 'D':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));
					break;
				case 'E':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));
					break;
				case 'F':
					result += (hexNum[i] - 'A' + 10) * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));
					break;
				default:
					result += (hexNum[i] - '0') * (int)(Math.Pow(16, (hexNum.Length - (i + 1))));;
					break;
			}
			
		}

		return result;
	}

	public static void Main()
	{
		Console.WriteLine("Enter a hexadecimal number:");
		string hexNum = Console.ReadLine();
		Console.WriteLine(ConvertHexadecimalToDecimal(hexNum));
	}
}

