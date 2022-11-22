//Chapter Primitive types and variable - book, Task 013
//22.11.2022, 23:24
using System;

public class SwapValues
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swap: a = {a}, b = {b}");

        int c = a;
        a = b;
        b = c;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}