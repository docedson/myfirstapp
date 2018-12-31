using System;

namespace classwork
{
    class Hello 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");

            // Created object instance of Car called myCar
            Car myCar = new Car();
            // This sets the value of Spiked to the object
            myCar.TypeTire = "Spiked";
            myCar.EngageTire(); // The spikes are engaged
            // This gets the value of Spiked from the object
            Console.WriteLine(myCar.TypeTire); // Engaged
            // This is a second object insance of Car
            Car mySecondCar = new Car();
            mySecondCar.TypeTire = "Nubbed";
            Console.WriteLine(mySecondCar.TypeTire); // Nubbed
            
        }
    }
}