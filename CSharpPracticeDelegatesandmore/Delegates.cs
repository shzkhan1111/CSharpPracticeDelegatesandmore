using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    
    public class Delegates
    {
        //type delagate (and name)
        public delegate double MathFunction(double a);
        public delegate double take2NumbersasArgs(double x, double y);


        //acts as a reference to the function
        public static void PlotFunction(MathFunction myfunc, double start, double end, double diff)
        {
            for (double x0 = start ; x0 < end; x0 += diff )
            {
                double y = myfunc(x0);
                Console.WriteLine($"{x0:N2} : {y:N2}");
            }
        }
                                                        //Param, return  max 16 param and 1 return type
                                                        //Func<int, void> Return type of void wont work 
                                                        //use Action<int> instead 
        public static void PlotFunctionGenericDelegate(Func<double , double> myfunc, double start, double end, double diff)
        {
            for (double x0 = start; x0 < end; x0 += diff)
            {
                double y = myfunc(x0);
                Console.WriteLine($"{x0:N2} : {y:N2}");
            }
        }
        public static void MultiplyNumbers(take2NumbersasArgs myfunc , double valPassed1 , double valuePassed2)
        {
            var output = myfunc(valPassed1, valuePassed2);
            Console.WriteLine($"output for value passed {valPassed1} and {valuePassed2} called via function is {output}");
        }




    }

}
