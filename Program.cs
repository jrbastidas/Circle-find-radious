using circleLab;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Circle circle2 = new Circle(-3);
            Console.WriteLine(circle2);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Circle circle3 = new Circle(0);
            Console.WriteLine(circle3);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
