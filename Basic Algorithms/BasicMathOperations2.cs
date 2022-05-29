//perform operations
public class Exercise7
{
    public static void Operations (int x, int y) {
        int sum = x + y;
        int dif = x - y;
        int prod = x * y;
        int quo = x / y;
        int mod = x % y;
        Console.WriteLine (x + "+" + y + "=" + sum);
        Console.WriteLine (x + "-" + y + "=" + dif);
        Console.WriteLine (x + "*" + y + "=" + prod);
        Console.WriteLine (x + "/" + y + "=" + quo);
        Console.WriteLine (x + "mod" + y + "=" + mod);
    }
    
    public static void Main(string[] args)
    {
        int num1, num2;
        Console.Write ("Input the first number: ");
        num1 = int.Parse (Console.ReadLine());
        Console.Write ("Input the second number: ");
        num2 = int.Parse (Console.ReadLine());
        Operations (num1,num2);
    }
}
