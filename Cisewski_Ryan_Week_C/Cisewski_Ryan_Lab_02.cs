using System;

public class CisewskiRyanLab2
{
    public static void Main()
    {

        Console.WriteLine("What kind of glasses would you like: ");

    Prescription:

        Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");

        int userOption = Convert.ToInt32(Console.ReadLine());

        if (userOption > 2 || userOption < 1)
        {
            goto Prescription;
        }


        Console.WriteLine("What kind of coating would you like: ");

    Coating:

        Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");

        int userCoating = Convert.ToInt32(Console.ReadLine());

        if (userCoating > 2 || userCoating < 1)
        {
            goto Coating;
        }
        Console.WriteLine("");

        if (userOption == 1)
        {
            if (userCoating == 1)
            {
                Console.WriteLine("Your total cost is $52.50");
            }
            else if (userCoating == 2)
            {
                Console.WriteLine("Your total cost is $49.99");
            }
        }
        else if (userOption == 2)
        {
            if (userCoating == 1)
            {
                Console.WriteLine("Your total cost is $37.50");
            }
            else if (userCoating == 2)
            {
                Console.WriteLine("Your total cost is $34.99");
            }

        }



        Console.ReadLine();
    }

}