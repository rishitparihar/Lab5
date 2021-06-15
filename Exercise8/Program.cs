using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class A
    {
        int X;
        public abstract void F(int n);
        private virtual void g(unsigned n)
    {
        X = n as int;
    }
    public string Tostring()
    {
        return X.ToString();
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
