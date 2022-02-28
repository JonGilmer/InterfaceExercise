using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Transmission { get; set; }
        public string Brakes { get; set; }
        public string BusinessLicense { get; set; }
        public string Employees { get; set; }

        // Default Constructor
        public Truck()
        { 
        }

        // Parameterized Constructor
        public Truck(string cabinType, string truckBedSize)
        {
            cabinType = CabinType;
            truckBedSize = TruckBedSize;
        }

        // Properties
        public string CabinType { get; set; }
        public string TruckBedSize { get; set; }

    }
}
