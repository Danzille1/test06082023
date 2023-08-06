int n1 = new Random().Next(1,8);

Console.Write("n1= ");
Console.WriteLine(n1);

if (n1 == 6)
 {
  Console.Write(n1);     
  Console.WriteLine(" -> да");
 }
 else
 {
  if (n1 == 7)
  {
   Console.Write(n1);     
   Console.WriteLine(" -> да");
  }
  else
  { 
   Console.Write(n1);     
   Console.WriteLine(" -> нет");
  }
 }