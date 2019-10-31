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
            Console.WriteLine("Accelerate - Without effect.");
        }

        public virtual void Decelerate()
        {
            Console.WriteLine("Decelerate - Without effect.");
        }

        public virtual void Brake()
        {
            Console.WriteLine("Brake - Without effect.");
        }

        public virtual void TurnOn()
        {
            Console.WriteLine("TurnOn - Without effect.");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("TurnOff - Without effect.");
        }

        public virtual void Fix()
        {
            Console.WriteLine("Fix - Without effect.");
        }
    }
}