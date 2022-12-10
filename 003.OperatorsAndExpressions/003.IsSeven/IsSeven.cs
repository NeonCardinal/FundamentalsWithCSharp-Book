//Chapter Operators and expressions - book, Task 003
//10.12.2022, 23:49
using System;

public class IsSeven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int a = number / 100;
        int b = a % 10;
        bool isThirdDigitEqSeven = b == 7;

        Console.WriteLine(isThirdDigitEqSeven);       
    }
}