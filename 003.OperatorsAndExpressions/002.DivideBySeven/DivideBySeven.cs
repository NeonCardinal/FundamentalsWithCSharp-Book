//Chapter Operators and expressions - book, Task 002
//10.12.2022, 23:46
using System;
using System.Diagnostics;

public class DivideBySeven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivided = number % 5 == 0 && number % 7 == 0;

        Console.WriteLine(isDivided);
    }
}