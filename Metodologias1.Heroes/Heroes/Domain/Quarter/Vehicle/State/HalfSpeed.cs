using System;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    public class HalfSpeed : Engine
    {
        public HalfSpeed(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void Accelerate()
        {
            Console.WriteLine("Speeding up...");
            this.Vehicle.SetState(new FullSpeed(Vehicle));
        }

        public override void Decelerate()
        {
            Console.WriteLine("Slowing down...");
            this.Vehicle.SetState(new SlowSpeed(Vehicle));
        }

        public override void Brake()
        {
            Console.WriteLine("Braking!!");
            this.Vehicle.SetState(new StandOff(Vehicle));
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning it off, it might not be a good idea...");
            this.Vehicle.SetState(new Broken(Vehicle));
        }
    }
}
