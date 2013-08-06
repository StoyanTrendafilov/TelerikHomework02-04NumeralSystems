//* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format
//(the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.


using System;

class Task09FlatRepresentation
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter one float number here : ");
        string number = Console.ReadLine();
        string beforeDecimalPoint = string.Empty;
        string afterDecimalPoint = string.Empty;
        int wholePart = 0;
        double drobnaPart = 0;
        int pointPosition = 0;
        int sign = 0; // (positive)
        if (number.Substring(0, 1) == "-")
        {
            sign = 1; // the number is negative   
        }
        for (int i = 0; i < number.Length; i++)
        {
            if (number.Substring(i, 1) == ".")
            {
                pointPosition = i;
                break;
            }
        }
        beforeDecimalPoint = number.Substring(0, pointPosition);
        afterDecimalPoint = number.Substring(pointPosition + 1, number.Length - (pointPosition + 1));
        wholePart = int.Parse(beforeDecimalPoint);
        drobnaPart = Convert.ToDouble(afterDecimalPoint);
        afterDecimalPoint = string.Empty;
        beforeDecimalPoint = Convert.ToString(wholePart, 2); // dwui4no predstawqne na mantisata
        int count = 0;
        while ((drobnaPart != 1) && (count < 23))
        {
            drobnaPart = drobnaPart * 2;
            if (drobnaPart < 1.0f)
            {
                afterDecimalPoint += "0";
            }
            else
            {
                drobnaPart -= 1;
                afterDecimalPoint += "1";
            }
            count++;
        }
        string exponent = (Convert.ToString(127 + beforeDecimalPoint.Length - 1.2));
        string mantis = string.Empty;
        for (int i = 1; i < beforeDecimalPoint.Length; i++)
        {
            mantis = mantis + beforeDecimalPoint.Substring(i, 1);
        }
        mantis = mantis + afterDecimalPoint;
        Console.WriteLine("Sign : \"{0}\";   Exponent : \"{1}\";   Mantissa : \"{2}\".", sign, exponent, mantis);
    }
}

