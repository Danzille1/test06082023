int n1 = new Random().Next(1,100);
int index = 1;

while (index <= n1)
{
 if (index % 2 == 0) 
  {
   Console.WriteLine(index);
  }
 index++; 
}

Console.Write("n1= ");
Console.WriteLine(n1);