﻿using System;

namespace MyMathLibrary
{
    public class MathFunctions
    {
        public int Factorial(int n)
        {
            int f = 1;
            for(int i=1;i<=n;i++)
            {
                f *= i;
            }
            return (f);
        }
    }
}
