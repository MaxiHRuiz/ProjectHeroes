using System;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    // Apagado
    public class TurnedOff : Engine
    {
        public TurnedOff(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("Vehicle ignited...");
            this.Vehicle.SetState(new StandOff(Vehicle));
        }

        public override string ToString()
        {
            return "The vehicle is off.";
        }
    }
}
