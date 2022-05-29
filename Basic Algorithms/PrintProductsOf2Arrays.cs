// Exercise 23 Print Product of corresponding elements of 2 arrays
    static void Main(string[] args) {
      int[] array1 = {0,0,0,0};
      int[] array2 = {0,0,0,0};
      for (int i=0; i < array1.Length; i++){
        Console.Write ("input array1 num " + (i + 1) + ": ");
        array1 [i] = int.Parse(Console.ReadLine());
        Console.Write ("input array2 num " + (i + 1) + ": ");
        array2 [i] = int.Parse(Console.ReadLine());
      }
      for (int i = 0; i < array1.Length; i++){
        int prod = array1[i] * array2[i];
        Console.Write(prod + " ");
      }
    }
