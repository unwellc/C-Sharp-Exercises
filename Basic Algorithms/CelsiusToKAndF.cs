//Converts temperature from Celsius to Kelvin and Fahrenheit
class Program
{
    static void Main()
    {
      int K, F;
      Console.Write("Input number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      K = num + 273;
      F = ((num * 9) / 5) + 32;
      Console.WriteLine ("Kelvin: " + K);
      Console.WriteLine ("Fahrenheit: "+ F);
    }
}
