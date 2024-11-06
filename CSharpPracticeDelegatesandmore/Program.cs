using CSharpPracticeDelegatesandmore;
using System.Security.Cryptography.X509Certificates;
using static CSharpPracticeDelegatesandmore.Delegates;

////function where i can pass Math function and a value and it will calc result and show
//Console.WriteLine("Calculating Math Sine");
//Delegates.PlotFunction(Math.Sin ,0.00 , Math.PI /2, 0.01);


Console.WriteLine("Calculating Math co Cosine");
Delegates.PlotFunction(Math.Cos, 0.00, Math.PI / 2, 0.01);
Console.WriteLine("Generic Delegate");
Delegates.PlotFunctionGenericDelegate(Math.Cos, 0.00, Math.PI / 2, 0.01);

//Console.WriteLine("Double");
//Delegates.PlotFunction(Helper.Double, 0.00, Math.PI / 2, 0.01);

//Console.WriteLine("Triple Via by passing Lambda Expression");
//Delegates.PlotFunction(x => x*3 , 0.00 , Math.PI / 2 , 0.01);

//Delegates.MultiplyNumbers(((x , y) => x * y), 6.00,8.00);

//Delegates are multicast

//will Exec in the order declared 
//Likely used when you have a void return type
MathFunction func = Helper.Tripling;
//func += Math.Cos;
//func += Math.Sqrt;
func += Helper.Double;
func += Helper.Tripling;
//func += Math.Sqrt;
var t = func(5);
Console.WriteLine($"{t}");






