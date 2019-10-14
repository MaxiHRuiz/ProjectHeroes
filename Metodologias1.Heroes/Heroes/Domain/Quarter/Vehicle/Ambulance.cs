using System;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class Ambulance : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The doctor drives the patrol car.");
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("The siren of the ambulance is on.");
        }
    }
}
