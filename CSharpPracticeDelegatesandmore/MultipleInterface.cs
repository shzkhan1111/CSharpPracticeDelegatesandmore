using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    public interface interface1
    {
        void Print();
        
    }
    public interface interface2
    {
        public void Print();
        public void Print2();
    }

    public class Student : interface1, interface2
    {
        //public void Print()
        //{
        //    Console.WriteLine("Printing Org");
        //}
        void interface1.Print()
        {
            Console.WriteLine("deded");
        }
        void interface2.Print()
        {
            Console.WriteLine("dededddededed");
        }

        public void Print2()
        {
            Console.WriteLine("Printing 2");
        }
        public const int ssomeconstant = 13;
    }
}
