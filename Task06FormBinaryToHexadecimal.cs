// Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
using System.Collections.Generic;

class Program
{
    static char PrinHexChar(string digits)
    {
        char res = new char();
        switch (digits)
        {
            case "0000" : res = '0';break;
            case "0001" : res = '1';break;
            case "0010" : res = '2';break;
            case "0011" : res = '3';break;
            case "0100" : res = '4';break;
            case "0101" : res = '5';break;
            case "0110" : res = '6';break;
            case "0111" : res = '7';break;
            case "1000" : res = '8';break;
            case "1001" : res = '9';break;
            case "1010" : res = 'A';break;
            case "1011" : res = 'B';break;
            case "1100" : res = 'C';break;
            case "1101" : res = 'D';break;
            case "1110" : res = 'E';break;
            case "1111" : res = 'F';break;
        }
        return res;
    }

    static void Main(string[] args)
    {
        Console.Write("Please, enter your decimal number here : ");
        string theNumber = Console.ReadLine();
        if (theNumber.Length % 4 != 0)
        {
            theNumber = theNumber.PadLeft(theNumber.Length + (4 - theNumber.Length % 4), '0');
        }
        int semiBytesCount = theNumber.Length / 4;
        List<char> number = new List<char>(theNumber);
        string[] hexChar = new string[semiBytesCount];
        for (int i = 0; i < theNumber.Length; i++)
        {
            hexChar[i / 4] += number[i];
        }
        string result = string.Empty;
        for (int i = 0; i < semiBytesCount; i++)
        {
            char res = PrinHexChar(hexChar[i]);
            result += res;
        }
        Console.WriteLine("the result is " + result);
    }
}

