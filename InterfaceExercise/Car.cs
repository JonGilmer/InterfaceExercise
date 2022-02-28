using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Transmission { get; set; }
        public string Brakes { get; set; }
        public string BusinessLicense { get; set; }
        public string Employees { get; set; }

        // Default Constructor
        public Car()
        {
        }

        // Parameterized Constructor
        public Car(int numberOfDoors, string trunkSize)
        {
            NumberOfDoors = numberOfDoors;
            TrunkSize = trunkSize;
        }

        // Properties
        public int NumberOfDoors { get; set; }
        public string TrunkSize { get; set; }

    }
}
