using System;
class Program {
  static void Main() {
      
     string str;
     int a, b;
     
     Console.WriteLine("\nCalculator\n\n");
     
     Console.WriteLine("Enter number 1:");
     
     str = Console.ReadLine();
     
     a = Convert.ToInt32(str);
     
     Console.WriteLine("Enter number 2:");
     
     str = Console.ReadLine();
     
     b = Convert.ToInt32(str);
     
     int result;
     int result1;
     int result2;
     
     result = a + b;
     result1 = a - b;
     result2 = a / b;
    
    Console.WriteLine("\n" + a + " + " + b + " = " + result);
    Console.WriteLine("\n" + a + " - " + b + " = " + result1);
    Console.WriteLine("\n" + a + " / " + b + " = " + result2);
  }
}
