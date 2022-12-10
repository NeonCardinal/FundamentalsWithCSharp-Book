//Chapter Operators and expressions - book, Task 005
//10.12.2022, 23:57
using System;

public class TrapeziodArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;

        Console.WriteLine(area);
    }
}