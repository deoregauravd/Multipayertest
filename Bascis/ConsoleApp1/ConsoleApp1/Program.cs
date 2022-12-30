using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
     class Arrays
    {
        static void Main(string[] args)
        {

            List<string> cars = new List<string>();
            cars.Add("Maruti");
            cars.Add("ford");
            cars.Add("BMW");

           /* for (int i = 0; i<cars.Count; i++) // for list we use count not lenght
            {
                Console.WriteLine(cars[i]);
            }*/

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
           //Console.WriteLine(cars[3]);
        }
    }
}
