using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int Wheels { get; set; }
        public string Motor { get; set; }
        public string Transmission { get; set; }
        public string Brakes { get; set; }

    }

}
