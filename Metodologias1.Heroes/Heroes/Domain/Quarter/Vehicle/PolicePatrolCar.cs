using System;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class PolicePatrolCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The cop drives the patrol car.");
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("The siren of the patrol car is on.");
        }
    }
}
