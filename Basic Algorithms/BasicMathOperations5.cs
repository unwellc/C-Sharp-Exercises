/*returns true if the sum, 1st number or 2nd number
is 20. Else return false
*/
    static void Main(string[] args) {
      bool total;
      Console.Write("Input number 1: ");
      int num1 = int.Parse(Console.ReadLine());
      Console.Write("Input number 2: ");
      int num2 = int.Parse(Console.ReadLine());
      int sum = num1 + num2;
      if (sum == 20 | num1 == 20 | num2 == 20){
        total = true;
      }
      else{
        total = false;
      }
      Console.WriteLine(sum);
      Console.WriteLine(total);
    }
