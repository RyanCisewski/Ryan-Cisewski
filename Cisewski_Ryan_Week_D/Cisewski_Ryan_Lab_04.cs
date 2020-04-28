using System;


public class CisewskiRyanLab4
{
    public static void Main()
    {
        int a = 1;
        int b = 3;
        int c = 5;

        double x = 2.2;
        double y = 4.4;
        double z = 6.6;
        double answer;


        answer = average(a, b);
        Console.WriteLine("average(a, b) = " + answer);
        Console.WriteLine("");


        answer = average(a, b, c);
        Console.WriteLine("average(a, b, c) = " + answer);
        Console.WriteLine("");



        answer = average(x, y);
        Console.WriteLine("average(x, y) = " + answer);
        Console.WriteLine("");

        answer = average(x, y, z);
        Console.WriteLine("average(x, y, z) = " + answer);
        Console.WriteLine("");


        Console.ReadLine();
    }

    public static double average(double n1, double n2)
    {
        return (n1 + n2) / 2.0;
    }
    public static double average(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3.0;
    }
    public static double average(int n1, int n2)
    {
        return (n1 + n2) / 2.0;
    }
    public static double average(int n1, int n2, int n3)
    {
        return (n1 + n2 + n3) / 3.0;
    }


}