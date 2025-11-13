using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuresex
{
    internal class Program
    {
        struct Car
        {
            public string make;
            public string model;
            public int price; 
        }

        static void Main(string[] args)
        {
            Car myCar;

            myCar.make = "Nissan";
            myCar.model = "Leaf";
            myCar.price = 2000;

            List<Car> carlist = new List<Car>();
            carlist.Add(myCar);

            myCar.make = "Fiat";
            myCar.model = "Panda";
            myCar.price = 200;

            carlist.Add(myCar);

            foreach (Car car in carlist)
            {
                Console.WriteLine(car.make);
                Console.WriteLine(car.model);
                Console.WriteLine(car.price);
            }
        }
    }
}
