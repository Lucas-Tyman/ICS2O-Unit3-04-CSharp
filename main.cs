// Created by: Lucas Tyman
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double celsius;
        double fahreneit;

        // input
        Console.WriteLine("This program converts fahrenheit to celsius. ");
        Console.WriteLine("");
        Console.WriteLine("the formula is: (°F - 32) * 5/9 = 0°C");
        Console.WriteLine("");
        Console.WriteLine("please enter the measurements below (℉)");
        Console.WriteLine("");

        Console.Write("Input fahrenheit:");
        fahreneit = Convert.ToDouble(Console.ReadLine());

        // process
        celsius = (fahreneit - 32) * 5 / 9;

        // output
        Console.WriteLine("");
        Console.WriteLine("The fahrenheit in celsius is, " + celsius.ToString("0.00") + "℃");
        Console.WriteLine("\nDone.");
    }
}