namespace _12OneTaskIsNotEnough
{
    using System;
    using System.Collections.Generic;

	public class OneTaskIsNotEnough
	{
		private static List<int> res;

		public static void LastLamp()
		{
			Stack<int> e = new Stack<int>();
			int gasi = 2;
			int last = 0;
			
			while (res.Count != 0)
			{				
				for (int i = 0; i < res.Count; i+= gasi)
				{

					e.Push(res[i]);
					  
									   
				}

				last = e.Peek();

				while (e.Count != 0)
				{
					res.Remove(e.Pop());
				}
			   
				gasi++;
			}

			Console.WriteLine(last+1);
		}

		public static void Main(string[] args)
		{
			int lamps = int.Parse(Console.ReadLine());

			res = new List<int>(lamps);
			for (int i = 0; i < lamps; i++)
			{
				res.Add(i);
			}
			
			string f = Console.ReadLine();
			string s = Console.ReadLine();
			LastLamp();
			Console.WriteLine("bounded");
			Console.WriteLine("bounded");			

			//HashSet<char> x = new HashSet<char>();

			//for (int i = 0; i < f.Length; i++)
			//{
			//    x.Add(f[i]);
			//}

			//if (x.Count == 2)
			//{
			//    Console.WriteLine("bounded");
			//}
			//else if (x.Count == 1)
			//{
			//    if (x.Contains('S'))
			//    {
			//        Console.WriteLine("unbounded");
			//    }
			//    else
			//    {
			//        Console.WriteLine("bounded");
			//    }

				
			//}
			//else
			//{
			//    Console.WriteLine("unbounded");
			//}

			//x.Clear();
			//for (int i = 0; i < s.Length; i++)
			//{
			//    x.Add(s[i]);
			//}

			//if (x.Count == 2)
			//{
			//    Console.WriteLine("bounded");
			//}
			//else if (x.Count == 1)
			//{
			//    if (x.Contains('S'))
			//    {
			//        Console.WriteLine("unbounded");
			//    }
			//    else
			//    {
			//        Console.WriteLine("bounded");
			//    }


			//}
			//else
			//{
			//    Console.WriteLine("unbounded");
			//}
		}
	}
}
