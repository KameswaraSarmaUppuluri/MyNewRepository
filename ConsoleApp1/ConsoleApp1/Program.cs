﻿using System;
using MyMathLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyMathLibrary.MathFunctions obj = new MathFunctions();

            Console.WriteLine("Result : {0}",obj.Factorial(5));

        }
    }
}
