//Chapter Operators and expressions - book, Task 001
//10.12.2022, 23:41
using System;

public class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isOdd = number % 2 != 0;

        if(isOdd)
            Console.WriteLine("odd");
        else
            Console.WriteLine("even");
    }
}