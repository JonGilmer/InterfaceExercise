using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(4, "15.4 cubic feet");
            myCar.Wheels = 4;
            myCar.Motor = "Inline 6";
            myCar.Transmission = "Automatic";
            myCar.Brakes = "4 Drum Brakes";
            myCar.BusinessLicense = "Corporation";
            myCar.Employees = "88,000 people";

            PrintCar(myCar);


            Truck myTruck = new Truck("Extended", "6.5 feet");
            myTruck.Wheels = 6;
            myTruck.Motor = "V8";
            myTruck.Transmission = "Manual";
            myTruck.Brakes = "";
            myTruck.BusinessLicense = "Corporation";
            myTruck.Employees = "219,000 people";

            PrintCar(myTruck);

            SUV mySUV = new SUV("Four Wheel Drive", 7);
            mySUV.Wheels = 4;
            mySUV.Motor = "V6";
            mySUV.Transmission = "Automatic";
            mySUV.Brakes = "2 Disk, 2 Drum";
            mySUV.BusinessLicense = "LLC";
            mySUV.Employees = "18,000";

            PrintCar(mySUV);
        }


        public static void PrintCar(Car c1)
        {
            Console.WriteLine("---------CAR---------");
            Console.WriteLine($"Company License Type: {c1.BusinessLicense}");
            Console.WriteLine($"Company Number of Employees: {c1.Employees}");
            Console.WriteLine($"\t Number of Doors: {c1.NumberOfDoors}");
            Console.WriteLine($"\t Trunk Size: {c1.TrunkSize}");
            Console.WriteLine($"\t Number of Wheels: {c1.Wheels}");
            Console.WriteLine($"\t Motor Type: {c1.Motor}");
            Console.WriteLine($"\t Transmission Type: {c1.Transmission}");
            Console.WriteLine($"\t Brake Type(s): {c1.Brakes}");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void PrintCar(Truck t1)
        {
            Console.WriteLine("---------TRUCK---------");
            Console.WriteLine($"Company License Type: {t1.BusinessLicense}");
            Console.WriteLine($"Company Number of Employees: {t1.Employees}");
            Console.WriteLine($"\t Number of Doors: {t1.TruckBedSize}");
            Console.WriteLine($"\t Trunk Size: {t1.CabinType}");
            Console.WriteLine($"\t Number of Wheels: {t1.Wheels}");
            Console.WriteLine($"\t Motor Type: {t1.Motor}");
            Console.WriteLine($"\t Transmission Type: {t1.Transmission}");
            Console.WriteLine($"\t Brake Type(s): {t1.Brakes}");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void PrintCar(SUV suv1)
        {
            Console.WriteLine("---------SUV---------");
            Console.WriteLine($"Company License Type: {suv1.BusinessLicense}");
            Console.WriteLine($"Company Number of Employees: {suv1.Employees}");
            Console.WriteLine($"\t Number of Doors: {suv1.DriveType}");
            Console.WriteLine($"\t Trunk Size: {suv1.NumberOfSeats}");
            Console.WriteLine($"\t Number of Wheels: {suv1.Wheels}");
            Console.WriteLine($"\t Motor Type: {suv1.Motor}");
            Console.WriteLine($"\t Transmission Type: {suv1.Transmission}");
            Console.WriteLine($"\t Brake Type(s): {suv1.Brakes}");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
