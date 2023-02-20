using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); //crear objeto/instancia a la clase coche. 
            //dar un estado inicial a nuestro coche

            Car car2 = new Car();

            Console.WriteLine(car1.getInfoCar());
            Console.WriteLine(car2.getInfoCar());

            Car car3 = new Car(4500.25, 1200.35);

            Console.WriteLine(car3.getInfoCar());

            car3.setExtras(true, "Cuero");
            Console.WriteLine(car3.getExtras());
        }

    }

    class Car
    {
        public Car() //dar un estado inicial a los objetos. Constructor
        {
            wheels = 4;

            lenght = 2300.5;

            width = 0.800;

        }

        public Car(double lenghtCar, double widthCar) //sobre carga de constyructor. Tener mas de 1 en una clase
        {
            wheels = 4;

            lenght = lenghtCar;

            width = widthCar;
        }

        public String getInfoCar()
        {
            return "Informacion del coche:\n " + "Ruedas: " + wheels + " Largo: " + lenght + " Ancho: " + width;
        }

        public void setExtras(bool paramAirCondition, String paramUnpholstery)
        {
            airConditioning = paramAirCondition;

            upholstery = paramUnpholstery;
        }

        public String getExtras()
        {
            return "Extras del coche:\n" + "Tapiceria: " + upholstery + " Aire Acondicionado: " + airConditioning;

        }

        private int wheels;

        private double lenght;

        private double width;

        private bool airConditioning;

        private String upholstery;
    }

}