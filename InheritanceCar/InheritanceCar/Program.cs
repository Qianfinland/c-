using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCar
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the car
            Car myCar = new Car();
            //set up the properties
            myCar.Make = "BMW";
            myCar.Model = "1000";
            myCar.Color = "Black";
            myCar.Year = 2010;

            //call the helper method printCarDetails
            printCarDetails(myCar);
            Console.ReadLine();
        }

        //define a helper method
        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here is the details of the Car: {0}", car.FormatMe());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //define a helper method
        public string FormatMe ()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }
}
