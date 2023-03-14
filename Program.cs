using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{

    static void Main(string[] args)
    {

        double x1, x2, y1, y2, x3, y3;
        Console.WriteLine("Enter coordinate x en A");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y en A");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate x en B");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y en B");
        y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate x en C");
        x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coordinate y en C");
        y3 = Convert.ToInt32(Console.ReadLine());

        double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        double perimetro = side1 + side2 + side3;


        Console.WriteLine("Length of side AB: " + side1);
        Console.WriteLine("Length of side BC: " + side2);
        Console.WriteLine("Length of side AC: " + side3);


        if (side1 == side2 && side1 == side3 && side2 == side3)
            Console.WriteLine("The triangle is Equilateral");
        else
            Console.WriteLine("The triangle is NOT Equilateral");
        {
            if (side1 == side2 || side1 == side3 || side2 == side3)

                Console.WriteLine("The triangle is Isosceles");
            else
                Console.WriteLine("The triangle is NOT isosceles");
            {
                if (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                    Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2) ||
                    Math.Pow(side3, 2) + Math.Pow(side1, 2) == Math.Pow(side2, 2))

                {
                    Console.WriteLine("The triangle is Rigth");
                }
                else
                {
                    Console.WriteLine("The triangle is NOT Rigth");
                }
            }

        }



        int i = 0;
        Console.WriteLine(" The perimeter is : " + perimetro);
        Console.WriteLine("parity numbers range from 0 to triangle perimeter");

        for (i = 0; i <= perimetro; i = i + 2)
        {
            Console.WriteLine(i);
        }








    }

}
