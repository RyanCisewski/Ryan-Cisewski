using System;

public class CisewskiRyanLab1
{
    public static void Main()
    {

        char s;
        char f;
        bool spicy;
        bool fancy;
        String userChoiceSpicy;
        String userChoiceFancy;


        Console.WriteLine("CS 201 Restaurant Guide");
        Console.WriteLine("");
        Console.WriteLine("Do you like spicy food? (y / n) :");
        userChoiceSpicy = Console.ReadLine();

        s = userChoiceSpicy[0];

        if (s == 'y' || s == 'Y')
        {
            spicy = true;
        }
        else
        {
            spicy = false;
        }

        Console.WriteLine("");
        Console.WriteLine("Do you want to go to a fancy restaurant? (y / n) :");
        userChoiceFancy = Console.ReadLine();

        f = userChoiceFancy[0];
        Console.WriteLine("");
        if (f == 'y' || f == 'Y')
        {
            fancy = true;
        }
        else
        {
            fancy = false;
        }

        if (spicy)
        {
            if (fancy)
            {
                Console.WriteLine("I suggest you go to Thai Garden Palace.");
            }
            else
            {
                Console.WriteLine("I suggest you go to Alberto’s Tacqueria.");
            }
        }
        else
        {
            if (fancy)
            {
                Console.WriteLine("I suggest you go to Chez Paris.");
            }
            else
            {
                Console.WriteLine("I suggest you go to Joe’s Diner.");
            }

        }

        Console.ReadLine();

    }
}