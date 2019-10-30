using System;

namespace Heroes.Domain.Quarter.Vehicle
{
    public abstract class Engine
    {
        public IVehicle Vehicle { get; set; }

        public Engine(IVehicle vehicle)
        {
            this.Vehicle = vehicle;
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Without effect.");
        }

        public virtual void Decelerate()
        {
            Console.WriteLine("Without effect.");
        }

        public virtual void Brake()
        {
            Console.WriteLine("Without effect.");
        }

        public virtual void TurnOn()
        {
            Console.WriteLine("Without effect.");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Without effect.");
        }

        public virtual void Fix()
        {
            Console.WriteLine("Without effect.");
        }
    }
}