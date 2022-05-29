/*Prints the inputted number repeatedly switch
the middle 3 rows having 2 numbers
printed with one space at the middle
and the first and last row with 3 consecutive 
numbers printed with no spaces
*/
class Program
{
    static void print (int num) {
      for (int i = 0; i < 3; i++){
        Console.Write (num);
      }
      Console.WriteLine();
      for (int x = 0; x < 3; x++){
        for (int a = 0; a < 2; a++){
           Console.Write (num + " ");
        }
        Console.WriteLine ();
      }
      for (int i = 0; i < 3; i++){
        Console.Write (num);
      }
    }

    static void Main()
    {
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        print (num);
    }
}
