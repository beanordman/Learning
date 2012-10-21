using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    delegate int BinaryOp(int a, int b);
    
    class SimpleMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public static int StaticAdd(int a, int b)
        {
            return a + b;
        }
    }
    
    class Program
    {
        static  void DisplayDelegateInfo(Delegate d)
        {
            Console.WriteLine("Method Name: {0}", d.Method);
            Console.WriteLine("Type Name: {0}", d.Target);
        }

        static void DisplayMulticastInfo(MulticastDelegate md)
        {
            foreach(var d in md.GetInvocationList())
            {
                DisplayDelegateInfo(d);
            }
        }

        static void Main(string[] args)
        {
            var m = new SimpleMath();
            var add = new BinaryOp(m.Add);
            var sub = new BinaryOp((a, b) => a - b);

            add += SimpleMath.StaticAdd;

            DisplayMulticastInfo(add);
            DisplayMulticastInfo(sub);
            DisplayMulticastInfo(new BinaryOp(SimpleMath.StaticAdd));

            Console.WriteLine(add(1, 2));
            Console.WriteLine(sub(2, 1));
            
            Console.ReadLine();
        }
    }
}
