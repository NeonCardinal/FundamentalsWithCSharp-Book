//Chapter Console input and output, Task 002
//11.12.2022, 01:17
using System;

public class CircleArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}