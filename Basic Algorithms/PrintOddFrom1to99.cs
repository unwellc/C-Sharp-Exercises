//Exercise 22 Print Odd Numbers from 1 to 99
    static void Main(string[] args) {
     for (int num = 1; num < 100; num++){
       if (num % 2 >= 1){
         Console.Write (num);
       }
       else {
         Console.WriteLine();
       }
     }
    }
