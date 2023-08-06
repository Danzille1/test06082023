int n1 = new Random().Next(1,999999);

Console.Write("n1= ");
Console.WriteLine(n1);

if (n1 < 100)
 {
  Console.Write("Третьей цифры нет");     
 }
 else
 {
  int n3 = n1 /100;
  if (n3 < 10)
   {
    Console.Write("Третья цифра = ");
    Console.WriteLine(n3);
   }
   else
    {
     n3 = n3 % 10;  
     Console.Write("Третья цифра = ");
     Console.WriteLine(n3);
    } 
 }