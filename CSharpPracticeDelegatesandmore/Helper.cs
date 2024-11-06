using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    public class Helper
    {
      
        public static double Double(double d)
        {
            Console.WriteLine($"Doubling {d}");
            return d * 2;
        }
        public static double Tripling(double d)
        {
            Console.WriteLine($"Tripling {d}");
            return d * 3;
        }
        public static double printViaDelegate(double x, double y)
        {
            var res = x * y;
            Console.WriteLine($"Doubling {x} * {y} = {res}");
            return res;
        }

    }
}
