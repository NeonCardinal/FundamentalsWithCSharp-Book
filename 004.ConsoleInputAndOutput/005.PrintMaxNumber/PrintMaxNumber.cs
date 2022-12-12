//Chapter Console input and output - book, Task 006
//11.12.2022, 01:34
using System;

public class PrintMaxNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Greater number is: {Math.Max(a, b)}");
    }
}