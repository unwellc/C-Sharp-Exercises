//Checks if a number is positive or negative
class Program
{
   static void CheckInteger (int num) {
     if (num >= 0){
       Console.WriteLine ("Positive");
     }
     else{
       Console.WriteLine ("Negative");
     }
   }
   
    static void Main()
    {
      Console.Write("Input: ");
      int num = int.Parse(Console.ReadLine());
      CheckInteger (num);
    }
}
