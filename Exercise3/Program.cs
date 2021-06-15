using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Mainclass
    {
        static void f(string s)
        {
            s += "world";
        }
        [STAThread]
        static void Main(string[] args)
        {
            String s = "Hello";
            f(s);
            Console.WriteLine(s);
        }
    }

}
