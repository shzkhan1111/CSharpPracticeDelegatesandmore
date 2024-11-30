using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    public record Person(string firstname, string lastname)
    {
        public string AnotherMutableProperty { get; set; } = "";
        public string Greet()
        {
            return $"My name is {firstname} - {lastname} , {AnotherMutableProperty}";
        }
        public void Greeter()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // Simulate work and enter a Not Runnable state
            }
        }
    }
}

public class QuantityCannotBeZeroException : Exception
{
    public QuantityCannotBeZeroException() : base("Quantity cannot be zero") { }

}

public class Purchase
{
    public void DoPurchase(int quantity)
    {
        if (quantity == 0)
        {
            throw new QuantityCannotBeZeroException();
        }
        throw new Exception("Some Other type Of exception");
    }
}