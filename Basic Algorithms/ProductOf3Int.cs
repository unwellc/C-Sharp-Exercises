//multiply and output product of 3 numbers
public class Exercise6
{
    public static void Multiply (int x, int y, int z) {
        int prod = x * y * z;
        Console.WriteLine (x + "x" + y + "x" + z + "=" + prod);
    }
    
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        Console.Write ("Input the first number to multiply: ");
        num1 = int.Parse (Console.ReadLine());
        Console.Write ("Input the second number to multiply: ");
        num2 = int.Parse (Console.ReadLine());
        Console.Write ("Input the third number to multiply: ");
        num3 = int.Parse (Console.ReadLine());
        Multiply (num1,num2,num3);
    }
}
