using System;
public class Lab01
{
    public static void Main(string[] args)
    {
        //
        Console.WriteLine("CS 201 Restaurant Guide\n");
        string response;
        char s, f;
        bool spicy, fancy;
        // Ask user for his/her preference
        Console.Write("Do you like spicy food? (y / n) : ");
        response = Console.ReadLine();
        s = response[0];
        if (s == 'y' || s == 'Y')
        {
            spicy = true;
        }
        else
        {
            spicy = false;
        }
        // Ask user for his/her preference
        Console.Write("Do you want to go to a fancy restaurant? (y / n) : ");
        // Get the next token
        response = Console.ReadLine();
        // Look only at first character
        f = response[0];
        fancy = (f == 'y') || (f == 'Y');
        // Make suggestion
        if (spicy)
        {
            if (fancy)
            {
                Console.WriteLine("I suggest you go to Thai Garden Palace.");
            }
            else
            {
                Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
            }
        }
        else
        {
            if (!fancy)
            {
                Console.WriteLine("I suggest you go to Joe's Diner.");
            }
            else
            {
                Console.WriteLine("I suggest you go to Chez Paris.");
            }
        }
        return;
    }
}
