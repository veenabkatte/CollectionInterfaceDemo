using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionInterfaceDemo
{
    class IEnumeratorDemo
    {
        static void Main()
        {
            Car car1 = new Car { Year = 2010, ModelName = "Tata Indica" };
            Car car2 = new Car { Year = 2011, ModelName = "Tata Nexon" };
            Car car3 = new Car { Year = 2012, ModelName = "Tata Hexa" };

            using (Cars cars = new Cars())
            {
                cars[0] = car1;
                cars[1] = car2;
                cars[2] = car3;

                int index = 0;

                while (cars.MoveNext())
                {
                    var car = cars[index];
                    Console.WriteLine($"Model Year={car.Year}\t Model Name={car.ModelName}");
                    index++;
                }
            }
            Console.ReadLine();
        }
    }
}
