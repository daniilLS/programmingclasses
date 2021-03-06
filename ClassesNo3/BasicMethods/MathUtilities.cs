﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMethods
{
    public static class MathUtilities
    {
        public static double solveliniarequetion(double a, double b)
        {
            return a == 0 ? 0 : -b / a;
            //if (a ==0)

            //    return 0;

            //    return -b / a;


        }
        public static int GetBiggerNumber(int a, int b)
        {
            return a > b ? a : b;
            //if (a > b)
            //    return a;
            //else
            //    return b;
        }
        public static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public static bool IsPrime (int a)
        {
            if (a < 2)
                return false;

            for (int i=2; i<a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        public static bool AreCoPrime( int a,int b)
        {
           
            return GCD(a,b) == 1;
        }
    }
}
