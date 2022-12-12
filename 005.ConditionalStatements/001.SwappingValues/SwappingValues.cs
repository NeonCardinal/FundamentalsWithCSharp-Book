//Chapter Conditional Statements - book, Task 001
//13.12.2022, 00:09
using System;

public class SwappingValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if(a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}