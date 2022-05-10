using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter 1st Nummber");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd Nummber");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=50 (5*10)      
        b = a / b; //b=5 (50/10)      
        a = a / b; //a=10 (50/5)    
        Console.Write("After swap a= " + a + " b= " + b);
        Console.ReadKey();
    }
}
