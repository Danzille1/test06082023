int n1 = new Random().Next(1,100);
int n2 = new Random().Next(1,100);

Console.Write("n1= ");
Console.WriteLine(n1);
Console.Write("n2= ");
Console.WriteLine(n2);

if (n1 > n2) 
 {
  Console.WriteLine("n1 больше чем n2");
 }
 else
 { 
  Console.WriteLine("n2 больше чем n1");
 }