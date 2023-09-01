// See https://aka.ms/new-console-template for more information

int number = 51511;             
int newnumber = 0;           
int digits = 0;
int oldnumber = number;

Console.Write("number = "); 
Console.WriteLine(number);

while ( number > 0)
 {
  newnumber = newnumber * 10 + number % 10;   
  number = number / 10;           
  digits++;

  if (digits > 5)
  {
   Console.WriteLine("more than 5 digits, false"); 
   return;  
  }
 }

if (digits < 5)
 {
   Console.WriteLine("less than 5 digits, false"); 
   return;
 }

if (oldnumber == newnumber)
 {
  Console.WriteLine("palindrom !"); 
 } 
 else
 {
  Console.WriteLine("not a palindrom !");      
 }

Console.Write("new number = "); 
Console.WriteLine(newnumber);