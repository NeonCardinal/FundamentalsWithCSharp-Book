//Chapter Operators and expressions - book, Task 004
//10.12.2022, 23:53
using System;

public class ThirdBitCheck
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int number = int.Parse(Console.ReadLine());

        bool isOne = (number & 8) != 0;

        Console.WriteLine(isOne);
    }
}