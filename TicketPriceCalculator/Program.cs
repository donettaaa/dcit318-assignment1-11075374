using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7");
        else
            Console.WriteLine("Ticket Price: GHC10");
    }
}

