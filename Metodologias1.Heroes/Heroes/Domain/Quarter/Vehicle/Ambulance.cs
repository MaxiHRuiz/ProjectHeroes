using System;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class Ambulance : IVehicle
    {
        public Engine MotorEngine { get; set; }

        public Ambulance()
        {
            this.MotorEngine = new TurnedOff(this);
        }
        public void Drive()
        {
            Console.WriteLine("The doctor drives the patrol car.");
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("The siren of the ambulance is on.");
        }

        public void SetState(Engine engine)
        {
            this.MotorEngine = engine;
        }
    }
}
