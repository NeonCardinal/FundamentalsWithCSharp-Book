//Chapter Operators and expressions - book, Task 007
//11.12.2022, 00:32
using System;

public class MoonWeight
{
    static void Main()
    {
        Console.Write("Въведете вашето тегло: ");
        int earthWeight = int.Parse(Console.ReadLine());

        double moonWeight = earthWeight * 0.17;

        Console.Write("Вашето тегло на луната ще е: ");
        Console.WriteLine(moonWeight);
    }
}