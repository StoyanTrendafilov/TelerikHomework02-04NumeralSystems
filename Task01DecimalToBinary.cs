//Write a program to convert decimal numbers to their binary representation.


using System;

class Task01DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter one number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("In bynary numeral system, your number will look like this : " + Convert.ToString(number, 2));
    }
}
