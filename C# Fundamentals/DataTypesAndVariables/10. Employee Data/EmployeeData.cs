﻿/*Employee Data
Description

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee 
using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

using System;

public class EmployeeData
{
    public static void Main()
    {
        string firstName = "Milena";
        Console.WriteLine(firstName);

        string lastName = "Stancheva";
        Console.WriteLine(lastName);

        int age = 30;
        Console.WriteLine(age);

        char gender = 'f';
        Console.WriteLine(gender);

        long personalIdNumber = 8306112507L;
        Console.WriteLine(personalIdNumber);

        ulong uniqueEmployeeNumber = 27569999U;
        Console.WriteLine(uniqueEmployeeNumber);
    }
}