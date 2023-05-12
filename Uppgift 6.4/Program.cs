using System;

class program
{
    static int potens(int tal1, int tal2)
    {
        return (int)Math.Pow(tal1, tal2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(potens(4, 2));
    }
}