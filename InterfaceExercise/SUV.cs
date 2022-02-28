using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Transmission { get; set; }
        public string Brakes { get; set; }
        public string BusinessLicense { get; set; }
        public string Employees { get; set; }

        // Defautl Constructor
        public SUV()
        {
        }

        // Parameterized Constructor
        public SUV(string driveType, int numberOfSeats)
        {
            DriveType = driveType;
            NumberOfSeats = numberOfSeats;
        }

        // Properties
        public string DriveType { get; set; }
        public int NumberOfSeats { get; set; }

    }
}
