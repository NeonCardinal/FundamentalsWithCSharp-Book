//Chapter Conditional statements - book, Task 008
//13.12.2022, 00:48
using System;

public class PlayWithSwitch
{
    static void Main()
    {
        string command = Console.ReadLine();

        switch(command)
        {
            case "int":
                {
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                }
                break;
            case "double":
                {
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d + 1.00);
                }
                break;
            case "string":
                {
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "+");
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}