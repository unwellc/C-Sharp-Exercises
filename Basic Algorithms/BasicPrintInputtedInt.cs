//Prints the number inputted along with a sentence
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        Console.Write("Input age: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("You Look Older Than " + num);
    }
}
