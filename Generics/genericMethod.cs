using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class genericMethod
    {
        public static void Show<T>(T[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Show(a);
            string[] b = { "Kanika", "Deevanshu" };
            Show(b);

            Console.ReadLine();
        }
    }
}
