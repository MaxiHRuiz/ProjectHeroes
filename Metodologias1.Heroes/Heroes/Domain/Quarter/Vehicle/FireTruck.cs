using System;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class FireTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Firefighters drive the patrol car.");
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("The siren of the fire truck is on.");
        }
    }
}
