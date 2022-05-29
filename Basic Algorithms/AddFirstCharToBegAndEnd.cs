//Adds the first letter of the string to the beginning and end 
class Program
{
   static string Add (string input) {
     char[] charArray = input.ToCharArray();
     string firstLetter = charArray [0].ToString();
     return firstLetter;
   }
   
    static void Main()
    {
      Console.Write("Input: ");
      string input = Console.ReadLine();
      Console.WriteLine (Add(input) + input + Add(input));
    }
}
