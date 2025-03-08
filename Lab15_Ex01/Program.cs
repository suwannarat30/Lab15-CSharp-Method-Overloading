﻿// See https://aka.ms/new-console-template for more information
using static System.Console;
WriteLine(Calculator.AddValues(2, 3));
WriteLine(Calculator.AddValues(2, 3, 4));
WriteLine(Calculator.AddValues(2.5f, 3.7f));
WriteLine(Calculator.AddValues(2L, 3L));

public static class Calculator
{
    public static long AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static long AddValues(int a, int b)");
        return a + b;
    }
    public static long AddValues(int c, int d, int e)
    {
        WriteLine("Calculated by method: public static long AddValues(int c, int d, int e)");
        return c + d + e;
    }
    public static long AddValues(float f, float g)
    {
        WriteLine("Calculated by method: public static long AddValues(float f, float g)");
        return (long) (f + g);
    }
   public static long AddValues(long h, long i)
    {
        WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return (long) (h + i);
    }
}
