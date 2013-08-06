//Write a program to convert decimal numbers to their hexadecimal representation.


using System;

class Task03DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        //ver. 1.0
        Console.Write("Please, enter your decimal number here : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("var. 1 : In hexadecimal representation, your number is \"{0}\".", number.ToString("X"));
        Console.WriteLine("var. 2 : In hexadecimal representation, your number is \"{0:X}\".", number);
        //ver 1.0 ends here

        //ver. 2.0 / не е най-добрият, но ако изредим всички, може да не ми остане време за останалите задачки :Д
        string resutlAsString = string.Empty;
        while (number != 0)
        {
            int remainder = number % 16;
            number = number / 16;
            string str = string.Empty;
            switch (remainder)
            {
                case 0 :
                    str = "0";
                    break;
                case 1 :
                    str = "1";
                    break;
                case 2 :
                    str = "2";
                    break;
                case 3 :
                    str = "3";
                    break;
                case 4 :
                    str = "4";
                    break;
                case 5 :
                    str = "5";
                    break;
                case 6 :
                    str = "6";
                    break;
                case 7 :
                    str = "7";
                    break;
                case 8 :
                    str = "8";
                    break;
                case 9 :
                    str = "9";
                    break;
                case 10 :
                    str = "A";
                    break;
                case 11 :
                    str = "B";
                    break;
                case 12 :
                    str = "C";
                    break;
                case 13 :
                    str = "D";
                    break;
                case 14 :
                    str = "E";
                    break;
                case 15 :
                    str = "F";
                    break;

            }
            resutlAsString = resutlAsString + str;
        }
        char[] result = resutlAsString.ToCharArray();
        Array.Reverse(result);
        Console.Write("And in my method : ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
        
    }
}

