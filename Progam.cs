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
                
            // This is a second object instance of Car
            Car mySecondCar = new Car();
            mySecondCar.TypeTire = "Nubbed";
            Console.WriteLine(mySecondCar.TypeTire); // Nubbed

            Car myThirdCar = new Car();
            // This sets the value of Tinted to the object
            myCar.Window = "Tinted";
            myCar.ShadeWindow(); // The windows are shaded

            Car myFourthCar = new Car();
            myCar.Door = "Four Doors";
            myCar.ClosedDoor();

            Car myFifthCar = new Car();
            myCar.Gas = "on empty";
            myCar.Octane();

            new Car();
            myCar.TypeOfCar();
           
            
            
        }
    }
}