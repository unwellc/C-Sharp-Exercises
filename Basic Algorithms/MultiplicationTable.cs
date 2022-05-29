//multiplication table
public class Exercise8
{
    public static void mulTable (int x) {
        for (int i = 1; i <= 10; i++){
            int prod = x * i;
            Console.WriteLine (x + "*" + i + "=" + prod);
        }
    }
    
    public static void Main(string[] args)
    {
        int num1;
        Console.WriteLine ("Input number: ");
        num1 = int.Parse (Console.ReadLine());
        mulTable (num1);
    }
}
