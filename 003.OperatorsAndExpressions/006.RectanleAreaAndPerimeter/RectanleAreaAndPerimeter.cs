//Chapter Operators and expressions - book, Task 006
//11.12.2022, 00:29
using System;

public class RectanleAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int perimeter = (a + b) * 2;
        int area = a * b;

        Console.WriteLine($"Perimeter = {perimeter}");
        Console.WriteLine($"Area = {area}");
    }
}