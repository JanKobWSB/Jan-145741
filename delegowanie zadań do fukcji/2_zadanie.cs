using System;

class Program
{
    static void Main()
    {
        double x1 = 2.5;
        double y1 = 3.2;
        double x2 = 5.1;
        double y2 = 7.8;

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine(distance); // Output: 5.242640687119285
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double distanceSquared = deltaX * deltaX + deltaY * deltaY;
        double distance = Math.Sqrt(distanceSquared);

        return distance;
    }
}
