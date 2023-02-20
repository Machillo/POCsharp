using System;


namespace ConceptPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //performTask();

            var myVariable = new { Name = "Kenneth", Age = 23 }; //clase anonima

            Console.WriteLine(myVariable.Name + " " + myVariable.Age);

            var myOtherVariable = new { Name = "Taylor", Age = 2 };

            myVariable = myOtherVariable;
        }

        static void performTask()
        {
            Point origin = new Point();

            Point destination = new Point(128, 80);

            Point otherPoint = new Point();

            double distance = origin.DistanceTo(destination);

            Console.WriteLine($"La distancia entre los puntos es de: {distance}");

            Console.WriteLine($"Número de objetos creados: {Point.ObjectCounter()}");
        }
    }
}
