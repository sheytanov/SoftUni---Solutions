using System;
using System.Linq;

namespace Circles
{
    public class IntersectionOfCircles
    {
        public static void Main(string[] args)
        {
            int[] firstCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point
            {
                X = firstCircleParams[0],
                Y = firstCircleParams[1]
            };

            Circle firstCircle = new Circle
            {
                Radius = firstCircleParams[2],
                Center = firstPoint
            };

            Point secondPoint = new Point
            {
                X=secondCircleParams[0],
                Y =  secondCircleParams[1]
            };

            Circle secondCircle = new Circle
            {
                Radius = secondCircleParams[2],
                Center = secondPoint
            };

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            int deltaX = Math.Abs(firstCircle.Center.X - secondCircle.Center.X);
            int deltaY = Math.Abs(secondCircle.Center.Y - firstCircle.Center.Y);

            double distance = Math.Sqrt(deltaY*deltaY + deltaX*deltaX);
            int radiusSum = firstCircle.Radius + secondCircle.Radius;

            if (distance <= radiusSum)
            {
                return true;
            }

            return false;
        }

    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
