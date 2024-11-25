using CSharpPracticeDelegatesandmore;
using System.Text;

////function where i can pass Math function and a value and it will calc result and show
//Console.WriteLine("Calculating Math Sine");
//Delegates.PlotFunction(Math.Sin ,0.00 , Math.PI /2, 0.01);


//Console.WriteLine("Calculating Math co Cosine");
//Delegates.PlotFunction(Math.Cos, 0.00, Math.PI / 2, 0.01);
//Console.WriteLine("Generic Delegate");
//Delegates.PlotFunctionGenericDelegate(Math.Cos, 0.00, Math.PI / 2, 0.01);

////Console.WriteLine("Double");
////Delegates.PlotFunction(Helper.Double, 0.00, Math.PI / 2, 0.01);

////Console.WriteLine("Triple Via by passing Lambda Expression");
////Delegates.PlotFunction(x => x*3 , 0.00 , Math.PI / 2 , 0.01);

////Delegates.MultiplyNumbers(((x , y) => x * y), 6.00,8.00);

////Delegates are multicast

////will Exec in the order declared 
////Likely used when you have a void return type
//MathFunction func = Helper.Tripling;
////func += Math.Cos;
////func += Math.Sqrt;
//func += Helper.Double;
//func += Helper.Tripling;
////func += Math.Sqrt;
//var t = func(5);
//Console.WriteLine($"{t}");

//BankAccount ba = new BankAccount();


//ba.Withdrawn += (s, e) => Console.WriteLine($"Message 1 from bank is {e.Message}.");
//ba.Deposit(500);
//ba.WithDrawn2 += (s, e) => Console.WriteLine($"Message 2 from bank is {e.Message}.");
//ba.WithDrawn3 += (s, e) => Console.WriteLine($"Message 3 from bank is {e.Message}.");
//ba.WithDrawn3.Invoke(null, new AccountArgs { Message = "WithDrawn 2 You are Over Drawn" });
//ba.WithDrawn4 += (s, e) => Console.WriteLine($"Message 2 from bank is {e.Message}.");

////wont work as it is declared with event 
////ba.WithDrawn2.Invoke(null, new AccountArgs { Message = "WithDrawn 2 You are Over Drawn" });

//ba.Withdraw(1000);


//Console.WriteLine(ba.Balance);


//Delegates de = new Delegates();

//de.Wrap(de.fu1);
//de.Wrap(de.fu2);
//de.Wrap(de.fu1);

//de.Try(de.fu1);
//de.Try(de.fu3);

//string str = "123qweasdzxc";
//var arr = str.ToCharArray();
//var st = new string(arr);
//Console.WriteLine(st);

//Array.Reverse(arr);
//var st1 = new string(arr);

//Console.WriteLine(st1);

//string st1 = "this is the first word";
//var str2 = st1.Split(' ');
//string res = "";
//for (int i = str2.Length - 1; i>=0;i--)
//{
//    res = res + " " + str2[i];
//}

////Console.WriteLine(res);

//string pal = "racecar";
//int st = 0, end = pal.Length - 1;
//bool ispal = true;
//while (st < end)
//{
//    Console.WriteLine($"{pal[st]} != {pal[end]}");


//    if (pal[st] != pal[end])
//    {
//        ispal = false;
//    }
//    st++;
//    end--;
//}

//if (ispal)
//{
//    Console.WriteLine("Palindrome");
//}
//else
//{
//    Console.WriteLine("not Palindrome");
//}

//string t = "abncabbcuuoip";
//int[] indexes = new int[26];
//StringBuilder res = new StringBuilder();
//for (int i = 0; i < t.Length; i++)
//{
//    int index = t[i] - 'a';
//    indexes[index]++;
//}

//for (int i = 0; i < t.Length; i++)
//{
//    int index = t[i] - 'a';
//    if (indexes[index] <= 1)
//    {
//        res.Append(t[i]);
//    }
//}

//string output = res.ToString();
//Console.WriteLine(output);


//int sum = 0;
//int x = 91901;

//while (x > 0)
//{
//    var rem = x % 10;
//    sum = sum * 10 + rem;
//    x = x/ 10;
//    Console.WriteLine(sum);

//}
//Console.WriteLine(sum);


//var num1 = Delegates.functDo(Delegates.functMul, 3, 5);
//var num2 = Delegates.functDo(Delegates.functSum, 3, 5);

//Console.WriteLine($"{num1} , {num2}");

PartyHost AlexFareWellParty = new PartyHost();

Attendants James = new Attendants("James");
Attendants James1 = new Attendants("ded");
Attendants James3 = new Attendants("ededed");
Attendants James5 = new Attendants("James5");

//register a response for the event 
AlexFareWellParty.InFormAttendees += James.InformNo;
AlexFareWellParty.InFormAttendees += James1.InformYes;
AlexFareWellParty.InFormAttendees += James3.InformYes;
AlexFareWellParty.InFormAttendees += James5.InformNo;

AlexFareWellParty?.InvokeEvent();