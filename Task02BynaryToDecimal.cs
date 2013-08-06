//Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;

class Task02BynaryToDecimal
{
    static void Main(string[] args)
    {
        //ver. 1.0
        Console.Write("Please, enter your number in bynary representation  : ");
        string number = Console.ReadLine();
        Console.WriteLine("The number, you have entered is : " + Convert.ToInt32(number, 2));
        //ver. 1.0 ends here 

        //ver. 2.0
        Console.Write("Please, enter your number here : ");
        string theNumber = Console.ReadLine();
        List<int> numberForCOnversion = new List<int>();
        bool negative = false;
        for (int i = 0; i < theNumber.Length; i++)
        {
            numberForCOnversion.Add((theNumber[i] - '0'));
        }
        if (numberForCOnversion.Count == 32 && numberForCOnversion[0] == 1)
        {

            negative = true;
            numberForCOnversion.RemoveAt(0);
        }
        int result = 0;
        for (int i = numberForCOnversion.Count- 1,  power = 0; i >= 0; i--, power ++)
        {
            if (theNumber[i] == '1')
            {
                result = result + Convert.ToInt32(Math.Pow(2, power));
            }
        }
        if (negative)
        {
            result *= -2; // умножаваме по -2, защото иначе, чрез numberForCOnversion.RemoveAt(0) премахваме един разряд
        }                   // - броя на елементите става с 1 по-малък. съответно степента на двойката става с едно по-малко.
        Console.WriteLine("Your number, calculatet by \"mine\" method is : " + result);
        // ver. 2.0 ends here 
    }
}

