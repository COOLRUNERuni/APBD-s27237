﻿// See https://aka.ms/new-console-template for more information

class MyClass
{


    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 56, 4 };
        Console.WriteLine(calcAvg(arr));
    }


    public static int calcAvg(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return sum / a.Length;
    }
}