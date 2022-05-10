using System;
public class PowerOfTwo
{

    public static void Main()
    {
        double n;
        Console.Write(" Enter the number to check power of 2 : ");
        n = Convert.ToInt32(Console.ReadLine()); 
        if(n <= 31) //using ifelse for get power up yo 31
        {
            double res = Math.Pow(2, n); //using Math function to get power
            Console.WriteLine("Result= {0}", res);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Enter the Value upto 31 to get power of 2");
        }
        
    }
}
