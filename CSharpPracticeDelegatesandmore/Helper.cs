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
    public class PartyHost
    {
        public event Action? InFormAttendees;
        //public PartyHost()
        //{
        //    Attending += () => { };
        //}
        public void InvokeEvent()
        {
            Console.WriteLine("Event Is being Invoked");
            InFormAttendees?.Invoke();
            Console.WriteLine("Attendees have been Invoked");
        }
    }
    public class Attendants
    {
        string name;
        public Attendants(string name)
        {
            this.name = name;
        }

        public void InformYes()
        {
            Console.WriteLine($"{this.name}, Yes I am Attending");
        }
        public void InformNo()
        {
            Console.WriteLine($"{this.name}, No I am Not Attending");
        }
    }
}
