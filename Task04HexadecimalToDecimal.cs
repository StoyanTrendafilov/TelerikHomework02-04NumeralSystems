//Write a program to convert hexadecimal numbers to their decimal representation.


using System;

class Program
{
   
    static void Main(string[] args)
    {
        Console.Write("Please, enter your hexadecimal number here : ");
        string hexNum = Console.ReadLine();
        int decNum = int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber); //var. 1 
        int decNum2 = Convert.ToInt32(hexNum, 16);//var. 2
        Console.WriteLine("Your number i decimal representation is : " + decNum);
        Console.WriteLine("Your number i decimal representation is : " + decNum2);
    }
}

