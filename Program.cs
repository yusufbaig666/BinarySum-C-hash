using System;

class Program
{
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static void Main(string[] args)
    {
        int num1, num2, result;
        num1 = Convert.ToInt32(Console.ReadLine());     
        num2 = Convert.ToInt32(Console.ReadLine());
        result = Add(num1, num2);
        Console.WriteLine( result);
        Console.ReadLine();
    }
}
