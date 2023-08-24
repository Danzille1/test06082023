// See https://aka.ms/new-console-template for more information

// int n0 = new Random().Next(10000,99999);
// Console.Write("number = ");
// Console.WriteLine(n0);

int number = 44444;

int n5 = (number / 10000); // get 5th digit
if  (n5 < 10)          // 5th digit is within 0 - 9 
 {
   if (n5 > 0)
    {
     int n1 = number % 10;     // get 1st digit
     if (n5 != n1)    // fast compare for not a palindrome cause 1st and 5th digits are not equal
      {
       Console.Write(number); 
       Console.WriteLine(" - > False");
      }
      else
       {
        int n4 = (number / 1000) % 10; // get 2nd and 4th digits
        int n2 = (number / 10) % 10;
        if (n2 == n4)
         {
          Console.Write(number); 
          Console.WriteLine(" - > True");   
         }
       }
    }
    else
    {
     Console.Write(number);
     Console.WriteLine(" - > Число не пятизначное");
     Console.WriteLine("False");
    }
 }
 else
 {
  Console.Write(number);
  Console.WriteLine(" - > Число не пятизначное");
  Console.WriteLine("False");  
 }