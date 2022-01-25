﻿using System;

namespace Pluralsight.UnitTestDemo.Api
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Divide(int value1, int value2)
        {
            if (value2 == 0)
            {
                throw new InvalidOperationException("Argument cannot be zero.");
            }
            return value1 / value2;
        }
    }
}
