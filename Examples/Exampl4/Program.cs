int n1 = new Random().Next(1,100);
int n2 = new Random().Next(1,100);
int n3 = new Random().Next(1,100);

Console.Write("n1= ");
Console.WriteLine(n1);

Console.Write("n2= ");
Console.WriteLine(n2);

Console.Write("n3= ");
Console.WriteLine(n3);

if (n1 > n2) 
 {
  if (n1 > n3) 
   {
    Console.WriteLine("n1 - максимальное число");
   }
   else
    {
     Console.WriteLine("n3 - максимальное число");
    }
 }
  else
 { 
  if (n2 > n3) 
   {
    Console.WriteLine("n2 - максимальное число"); 
   } 
    else
    {
     Console.WriteLine("n3 - максимальное число");    
    } 
 }