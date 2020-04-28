using System;


public class CisewskiRyanLab3
{
    public static void Main()
    {
        char s;
        string temp;
        double userAmount;
        double currentAmount;
        double actualAmount;
        double finalAmount;



        currentAmount = 45.32;
        finalAmount = 0;
        actualAmount = 0;
        Console.WriteLine("Please enter a amount to update account by $");
        temp = Console.ReadLine();
        Console.WriteLine("");

        s = temp[0];

        userAmount = double.Parse(temp);

        if (s != '-')
        {
            actualAmount = currentAmount + userAmount;
            finalAmount = currentAmount + userAmount;
        }
        else if (s == '-')
        {
            if (userAmount * -1 > currentAmount)
            {
                actualAmount = currentAmount;
                finalAmount = 0;
            }
            else
            {
                actualAmount = userAmount;
                finalAmount = currentAmount + userAmount;
            }
        }


        Console.WriteLine("Customer's balance (before transaction) = $" + currentAmount);
        Console.WriteLine("");


        Console.WriteLine("Requested update amount = $" + userAmount);
        Console.WriteLine("");


        Console.WriteLine("Actual update amount = $" + actualAmount);
        Console.WriteLine("");


        Console.WriteLine("Customer's balance (after transaction) = $" + finalAmount);
        Console.WriteLine("");


        Console.WriteLine("Thank you and goodbye!");


        Console.ReadLine();

    }
}