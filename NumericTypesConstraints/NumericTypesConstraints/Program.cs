﻿using System.Numerics;

Console.WriteLine("Square of 2 is: " + Calculator.Square(2));
Console.WriteLine("Square of 4m is: " + Calculator.Square(4m));
Console.WriteLine("Square of 6d is: " + Calculator.Square(6d));

Console.ReadLine();

public static class Calculator
{
    public static T Square<T>(T input) where T : INumber<T>
        => input * input;
}