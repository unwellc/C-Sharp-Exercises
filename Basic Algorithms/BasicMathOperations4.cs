/*Converts the difference of 2 integer to positive
if it is negative, else multiply the difference by 2
*/
    static void Main(string[] args) {
      Console.Write("Input number 1: ");
      int num1 = int.Parse(Console.ReadLine());
      Console.Write("Input number 2: ");
      int num2 = int.Parse(Console.ReadLine());
      int dif = num1 - num2;
      if (dif < 0){
        dif = Math.Abs(dif);
      }
      else{
        dif = dif * 2;
      }
      Console.WriteLine(dif);
    }
