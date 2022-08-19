using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{

    public class A
    {
        public void Fun()
        {
            Console.Write("This is function A");
        }
    }

    public class B
    {
        public void Fun2()
        {
            Console.Write("This is Function B");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
            a.Fun();
            Console.ReadKey();
        }    
    }
}
