using System;

namespace TechTask
{
    class Program
    {
        static void Main()
        {
            float coordinateXOfDotA, coordinateYOfDotA, coordinateXOfDotB, coordinateYOfDotB, coordinateXOfDotC, coordinateYOfDotC;
            double deltaEqual = 0.00001;
            /* get coordinates of dots */
            Console.WriteLine("Enter the coordinate x of dot A");
            coordinateXOfDotA = GetCoordinate(Console.ReadLine());
            Console.WriteLine("Enter the coordinate y of dot A");
            coordinateYOfDotA = GetCoordinate(Console.ReadLine());
            Console.WriteLine("Enter the coordinate x of dot B");
            coordinateXOfDotB = GetCoordinate(Console.ReadLine());
            Console.WriteLine("Enter the coordinate y of dot B");
            coordinateYOfDotB = GetCoordinate(Console.ReadLine());
            Console.WriteLine("Enter the coordinate x of dot C");
            coordinateXOfDotC = GetCoordinate(Console.ReadLine());
            Console.WriteLine("Enter the coordinate y of dot C");
            coordinateYOfDotC = GetCoordinate(Console.ReadLine());
            /* get lenghts of sides */
            double lenghtAB = GetLenghts(coordinateXOfDotA, coordinateYOfDotA, coordinateXOfDotB, coordinateYOfDotB);
            Console.WriteLine("Lenghts of AB is: " + lenghtAB);
            double lenghtBC = GetLenghts(coordinateXOfDotB, coordinateYOfDotB, coordinateXOfDotC, coordinateYOfDotC);
            Console.WriteLine("Lenghts of BC is: " + lenghtBC);
            double lenghtAC = GetLenghts(coordinateXOfDotA, coordinateYOfDotA, coordinateXOfDotC, coordinateYOfDotC);
            Console.WriteLine("Lenghts of AC is: " + lenghtAC + "\n");
            /* equilateral check */
            if ((Math.Abs(lenghtAB - lenghtBC) <= deltaEqual) && (Math.Abs(lenghtBC - lenghtAC) <= deltaEqual))
            {
                Console.WriteLine("Triangle is equilateral.");
            }
            else
            {
                Console.WriteLine("Triangle is NOT equilateral.");
            }
            /* isosceles check */
            if ((Math.Abs(lenghtAB - lenghtAC) <= deltaEqual) || (Math.Abs(lenghtAB - lenghtBC) <= deltaEqual) || (Math.Abs(lenghtAC - lenghtBC) <= deltaEqual))
            {
                Console.WriteLine("Triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("Triangle is NOT isosceles.");
            }
            /* rectangular check */
            if (Math.Abs(Math.Pow(lenghtAB, 2) - (Math.Pow(lenghtBC, 2) + Math.Pow(lenghtAC, 2))) <= deltaEqual)
            {
                Console.WriteLine("Triangle is rectangular.\n");
            }
            else if (Math.Abs(Math.Pow(lenghtAC, 2) - (Math.Pow(lenghtAB, 2) + Math.Pow(lenghtBC, 2))) <= deltaEqual)
            {
                Console.WriteLine("Triangle is rectangular.\n");
            }
            else if (Math.Abs(Math.Pow(lenghtBC, 2) - (Math.Pow(lenghtAB, 2) + Math.Pow(lenghtAC, 2))) <= deltaEqual)
            {
                Console.WriteLine("Triangle is rectangular.\n");
            }
            else
            {
                Console.WriteLine("Triangle is NOT rectangular.\n");
            }
            /* find perimeter */
            double perimeter = lenghtAB + lenghtBC + lenghtAC;
            Console.WriteLine("Perimeter lenght: " + perimeter + "\n");
            /* find parity numbers */
            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (var i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            /* end of program */
            Console.WriteLine("Program is done. Press \"Enter\" to exit.");
            Console.ReadLine();
        }
        private static float GetCoordinate(string inputString)
        {
            float parseResult;
            if (float.TryParse(inputString, out parseResult))
            {
                return parseResult;
            }
            else
            {
                Console.WriteLine("Can\'t convert coordinate. Please, try again.");
                return GetCoordinate(Console.ReadLine());
            }
        }
        private static double GetLenghts(double firstCoordinateX, double firstCoordinateY, double secondCoordinateX, double secondCoordinateY)
        {
            return Math.Sqrt((Math.Pow((secondCoordinateX - firstCoordinateX), 2)) + (Math.Pow((secondCoordinateY - firstCoordinateY), 2)));
        }
    }
}