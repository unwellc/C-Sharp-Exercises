//calculate average of 5 inputted values
public class Exercise9
{
    public static void Average (List<int> x) {
        Console.Write ("The average of ");
        for (int i = 0; i < 5; i++){
            Console.Write(x.ElementAt(i)+",");
        }
        
        Console.WriteLine (" is: " + x.Average());
    }
    
    public static void Main(string[] args)
    {
        List<int> num = new List<int>();
        for (int i = 1; i <= 5; i++){
        Console.Write ("Input number" + i + ": ");
        num.Add(int.Parse (Console.ReadLine()));
        }
        Average (num);
    }
}
