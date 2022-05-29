//Prints the result of a predetermined operations on inputted 3 integers
public class Exercise10
{
    public static void Calcu (List<int> x) {
        Console.Write ("Result of specified numbers ");
        for (int i = 0; i < 3; i++){
            Console.Write(x.ElementAt(i)+", ");
        }
        Console.Write("(x+y)*z is " + ((x.ElementAt(0)+x.ElementAt(1))*x.ElementAt(2)));
        int xy = x.ElementAt(0) * x.ElementAt(1);
        int yz = x.ElementAt(1) * x.ElementAt(2);
        int total = xy + yz;
        Console.Write(" and x*y + y*z is " + total);
    }
    
    public static void Main(string[] args)
    {
        List<int> num = new List<int>();
        for (int i = 1; i <= 3; i++){
        Console.Write ("Input number" + i + ": ");
        num.Add(int.Parse (Console.ReadLine()));
        }
        Calcu (num);
    }
}
