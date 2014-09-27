////Task 7
////Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element
////in the  GenericList<T>. You may need to add a generic constraints for the type T.

namespace Euclidian3DSpace
{
    using System;

    public class Program
    {     
        public static T Max<T>(GenericList<T> arr) where T : IComparable
        {
            T best = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if (best.CompareTo(arr[i]) < 0)
                {
                    best = arr[i];
                }
            }

            return best;
        }

        public static T Min<T>(GenericList<T> arr) where T : IComparable
        {
            T best = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if (best.CompareTo(arr[i]) > 0)
                {
                    best = arr[i];
                }
            }

            return best;
        }

        public static void Main(string[] args)
        {
            Point3D x = new Point3D(20, 30, 4);

            Console.WriteLine(x.ToString());

            GenericList<int> a = new GenericList<int>(5);

            a.Add(5);
            a.Add(10);
            a.Add(18);
            a.Add(22);
            a.Add(9);

            int c = a.Count;
            int b = a.FindPosition(10);

            a.InsertAt(1, 111);
            a.RemoveAt(2);

            a.Add(6);
            a.Add(99);
            a.Add(18);
            Console.WriteLine(a.ToString());
            int cf = a.Count;
            int dd = Min(a);

            Matrix<int> prase = new Matrix<int>(2, 2);

            prase[0, 0] = 1;
            prase[0, 1] = 2;
            prase[1, 1] = 3;

            Matrix<int> prase2 = new Matrix<int>(2, 2);

            prase2[0, 0] = 1;
            prase2[0, 1] = 2;
            prase2[1, 1] = 3;

            Matrix<int> res = prase - prase2;            

            if (res)
            {
                Console.WriteLine("Is 0 type");
            }
            else
            {
                Console.WriteLine("Isn't 0 type");
            }

            Type typeMatrix = typeof(Matrix<int>);
            foreach (var attr in typeMatrix.GetCustomAttributes(false))
            {
                if (attr is VersionAttribute)
                {
                    Console.WriteLine(
                        "This is version {0} of the {1} class.",
                        (attr as VersionAttribute).GetVersion,
                        typeof(Matrix<int>).FullName);
                }
            }
        }
    }
}
