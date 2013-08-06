//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).


using System;

class Task07FromRandomToRandomNumeralSystem
{
    static Int32 FromRandomToDecimal(string number, int theBase)
    {
        int outValue = 0;
        char[] charToDex = number.ToCharArray();
        Array.Reverse(charToDex);
        int[] decimalValues = new int[charToDex.Length];
        for (int i = 0; i < decimalValues.Length; i++)
        {
            switch (charToDex[i])
            {
                case '0': decimalValues[i] = 0; break;
                case '1': decimalValues[i] = 1; break;
                case '2': decimalValues[i] = 2; break;
                case '3': decimalValues[i] = 3; break;
                case '4': decimalValues[i] = 4; break;
                case '5': decimalValues[i] = 5; break;
                case '6': decimalValues[i] = 6; break;
                case '7': decimalValues[i] = 7; break;
                case '8': decimalValues[i] = 8; break;
                case '9': decimalValues[i] = 9; break;
                case 'A': decimalValues[i] = 10; break;
                case 'B': decimalValues[i] = 11; break;
                case 'C': decimalValues[i] = 12; break;
                case 'D': decimalValues[i] = 13; break;
                case 'E': decimalValues[i] = 14; break;
                case 'F': decimalValues[i] = 15; break;
            }
        }
        for (int i = 0; i < decimalValues.Length; i++)
        {
            outValue += decimalValues[i] * (Int32)(Math.Pow(theBase, i));
        }
        return outValue;
    }

    static string FromDecimalToRandom(int theNumber, int theBase)
    {
        string result = string.Empty;
        while (theNumber != 0)
        {
            int remainder = theNumber % theBase;
            char temp = new char();
            switch (remainder)
            {
                case 0: temp = '0'; break;
                case 1: temp = '1'; break;
                case 2: temp = '2'; break;
                case 3: temp = '3'; break;
                case 4: temp = '4'; break;
                case 5: temp = '5'; break;
                case 6: temp = '6'; break;
                case 7: temp = '7'; break;
                case 8: temp = '8'; break;
                case 9: temp = '9'; break;
                case 10: temp = 'A'; break;
                case 11: temp = 'B'; break;
                case 12: temp = 'C'; break;
                case 13: temp = 'D'; break;
                case 14: temp = 'E'; break;
                case 15: temp = 'F'; break;
            }
            result += temp;
            theNumber /= theBase;
        }
        char[] prePrint = result.ToCharArray();
        Array.Reverse(prePrint);
        return new string(prePrint);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("When entering bases, please, have in mind, that they should be in range from 2 \nto 16 including.");
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.Write("Please, enter the base of the numeral system, that your number has, here : ");
        int inputBase = int.Parse(Console.ReadLine());
        Console.Write("Please, enter your number here : ");
        string number = Console.ReadLine();
        Console.Write("Please, enter the base of the numeral system, that you want to print your number in : ");
        int printBase = int.Parse(Console.ReadLine());
        int decimalValue = FromRandomToDecimal(number, inputBase);
        string finalResult = FromDecimalToRandom(decimalValue, printBase);
        Console.WriteLine("And the wanted result is : " + finalResult);
    }
}
