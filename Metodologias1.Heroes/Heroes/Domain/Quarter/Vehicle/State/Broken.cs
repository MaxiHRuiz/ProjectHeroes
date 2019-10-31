using System;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    public class Broken : Engine
    {
        public Broken(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void Fix()
        {
            Console.WriteLine("Fixing the vehicle...");
            this.Vehicle.SetState(new TurnedOff(Vehicle));
        }
    }
}
