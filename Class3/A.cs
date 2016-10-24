using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class A
    {
        internal A()
        {
            Console.Write("A");
        }
        internal A(int a1, int a2) : this(a1)
        {
            Console.WriteLine("{0}{1}", a1, a2);
        }
        internal A(int a3) : this()
        {
            Console.Write("{0}", a3);
        }
    }
}