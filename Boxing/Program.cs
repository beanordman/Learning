using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object o = (object) n;
            int m = (int) o;
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
}
