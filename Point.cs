using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptPOO
{
    internal class Point
    {
        public Point(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;

            this.y = y;

            objectCounter++;
        }

        public Point()
        {
            //Console.WriteLine("Este es el constructor por defecto");
            this.x = 0;

            this.y = 0;

            objectCounter++;
        }

        public double DistanceTo(Point otherPoint)
        {
            int xDif = this.x - otherPoint.x;

            int yDif = this.y - otherPoint.y;

            double distancePonits = Math.Sqrt(Math.Pow(xDif, 2)+ Math.Pow(yDif, 2));

            return distancePonits;
        }

        /*public static int ObjectCounter()
        {
            return objectCounter;
        }*/

        public static int ObjectCounter() => objectCounter;
        
        private int x, y;

        private static int objectCounter = 0;
    }
}
