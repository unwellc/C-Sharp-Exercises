//Swap 2 number input
using System;

public class Exercise5
{
    public static void swapNum (int x, int y) {
        int tempswap = x;
        x = y;
        y = tempswap;
        Console.WriteLine ("After Swapping: \n" + "First Number: " + x + "\nSecond Number: " + y);
    }
    
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.Write ("Input the first number: ");
        num1 = int.Parse (Console.ReadLine());
        Console.Write ("Input the second number: ");
        num2 = int.Parse (Console.ReadLine());
        swapNum (num1,num2);
    }
}
