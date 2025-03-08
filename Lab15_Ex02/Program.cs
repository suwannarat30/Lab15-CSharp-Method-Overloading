﻿using static System.Console;

WriteLine(Calculator.AddValues(2, 3));
WriteLine(Calculator.AddValues(2.0f, 3.0f));
WriteLine(Calculator.AddValues(2L, 3L));

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    public static long AddValues(long a, long b)
    {
        WriteLine("Calculated by method: public static long AddValues(long a, long b)");
        return a + b;
    }

    public static float AddValues(float a, float b)
    {
        WriteLine("Calculated by method: public static float AddValues(float a, float b)");
        return a + b;
    }

    public static double AddValues(double a, double b)
    {
        WriteLine("Calculated by method: public static double AddValues(double a, double b)");
        return a + b;
    }
}
