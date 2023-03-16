// main.cs
using System;
using System.Runtime.InteropServices;

public class MainClass
{
    [DllImport("libgo.dll", EntryPoint = "HelloWorld")]
    public static extern void HelloWorld(); // function signature, must have a return type

    [DllImport("libgo.dll", EntryPoint = "Sum")]
    public static extern int Sum(int a, int b);

    static void Main()
    {
        HelloWorld();
        Console.WriteLine(Sum(1, 2));
    }
}
