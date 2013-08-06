//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


using System;


class Task08ShortNumberFullRepresentation
{

    static void Main(string[] args)
    {
        Console.Write("Please, enter one short number (smaller than 32767 and greater than -32768) : ");
        short theNumber = short.Parse(Console.ReadLine());
        short sign = (short)((theNumber >> 15) & 1); // проверяваме дали е положително или отрицателно число - ако е отрицателно sign = 1, aко е положително = 0
        string result = string.Empty;
        if (sign == 1)
        {
            theNumber *= -1; // ако е отрицалтено число - превръщаме го в положително.
        }
        while (theNumber != 0)
        {
            result += (theNumber % 2);
            theNumber = (short)(theNumber / 2);
        }
        char[] charArr = result.ToCharArray();
        Array.Reverse(charArr);
        string final = new string(charArr);
        Console.WriteLine("And your signed number looks like : " + sign + final.PadLeft(15, '0'));
    }
}

