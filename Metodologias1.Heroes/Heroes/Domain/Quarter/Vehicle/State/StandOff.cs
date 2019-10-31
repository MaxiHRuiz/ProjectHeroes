using System;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    // Punto muerto
    public class StandOff : Engine
    {
        public StandOff(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void Accelerate()
        {
            Console.WriteLine("Speeding up...");
            this.Vehicle.SetState(new SlowSpeed(Vehicle));
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning off...");
            this.Vehicle.SetState(new TurnedOff(Vehicle));
        }

    }
}