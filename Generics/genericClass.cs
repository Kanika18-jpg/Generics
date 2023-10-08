using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class genericClass <T>
    {
        T message;

        public genericClass(T message)
        {
            this.message = message;
            Console.WriteLine(message);
        }
    }
    class Program1
    {
        public static void Main(string[] args)
        {
            genericClass<string> g1 = new genericClass<string>("Hello");
            genericClass<int> g2 = new genericClass<int>(1);
            genericClass<char> g3 = new genericClass<char>('K');
            Console.ReadLine();
        }
    }
}
