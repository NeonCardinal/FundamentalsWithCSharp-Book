//Chapter Primitive types and variables - book, Task 007
//22.11.2022, 23:21
using System;

public class StringsAndObj
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object firstObj = first + " " + second;
        string third = (string)firstObj;

        Console.Write("This is object: ");
        Console.WriteLine(firstObj);
        Console.Write("This is string: ");
        Console.WriteLine(third);
    }
}