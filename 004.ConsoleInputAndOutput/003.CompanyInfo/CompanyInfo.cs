//Chapter Console input and output - book, Task 003
//11.12.2022, 01:22
using System;

public class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        int companyPhone = int.Parse(Console.ReadLine());
        int companyFax = int.Parse(Console.ReadLine());
        string companyWeb = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerPhone = int.Parse(Console.ReadLine());

        Console.WriteLine($"Company name: {companyName}, company address: {companyAddress}," +
            $" company phone: {companyPhone}, company fax: {companyFax}, company web: {companyWeb}");
        Console.WriteLine($"Manager first name: {managerFirstName}, manager last name: {managerLastName}, " +
            $"manager phone number: {managerPhone}");
    }
}