//Triples the sum of 2 numbers if the 2 numbers are equal, else prints the sum of 2 numbers
static void Main(string[] args) {
      Console.Write("Input number 1: ");
      int num1 = int.Parse(Console.ReadLine());
      Console.Write("Input number 2: ");
      int num2 = int.Parse(Console.ReadLine());
      int total = num1 + num2;
      if (num1 == num2){
        int triple = total * 3;
        Console.WriteLine (triple);
      }
      else{
        Console.WriteLine (total);
      }
    }
