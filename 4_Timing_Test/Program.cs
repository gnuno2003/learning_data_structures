using System;
class Program
{
    // * This code has two problems
    // * 1. The time measured by the test is added to the time of execution of the program
    // * 2. It doesn't take into account the garbage collection performed in the .NET environment
    static void DisplayNums(int[] arr)
    {
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
            Console.Write(arr[i] + " ");
    }
    static void Main()
    {
        DateTime startTime;
        TimeSpan endTime;
        startTime = DateTime.Now;
        int[] arr = { 1, 2, 3 };
        DisplayNums(arr);
        endTime = DateTime.Now.Subtract(startTime);
        Console.WriteLine("Start time: : " + startTime);
        Console.WriteLine("End time: : " + startTime);
    }
}