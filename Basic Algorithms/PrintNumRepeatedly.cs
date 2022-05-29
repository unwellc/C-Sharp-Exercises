//Prints the inputted number repeatedly in rows alternatingly with other rows having no spaces
class Program
{
    
    static void print (int num) {
        for (int x = 0; x < 2; x++){
            for (int i = 0; i < 4; i++){
                Console.Write (num + " ");
            }
            Console.WriteLine();
            for (int a = 0; a < 4; a++){
                Console.Write (num);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        print (num);
    }
}
