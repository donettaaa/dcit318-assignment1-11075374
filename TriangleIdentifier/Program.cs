using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Check for a valid triangle first
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("This is an Equilateral triangle.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("This is an Isosceles triangle.");
            else
                Console.WriteLine("This is a Scalene triangle.");
        }
        else
        {
            Console.WriteLine("This is not a valid triangle.");
        }
    }
}

