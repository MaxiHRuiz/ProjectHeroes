using System;
using Domain.RandomValue;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class PolicePatrolCar : IVehicle
    {
        public Engine MotorEngine { get; set; }

        public PolicePatrolCar()
        {
            this.MotorEngine = new TurnedOff(this);
        }

        public void Drive()
        {
            Console.WriteLine("The cop got into the vehicle.");
            for (int i = 0; i < 5; i++)
            {
                var chance = GenerateRandomValue.GetRandom(0, 11);

                if (chance <= 1)
                {
                    this.MotorEngine.TurnOff();
                    continue;
                }
                else if (this.MotorEngine.GetType() == typeof(TurnedOff))
                {
                    this.MotorEngine.TurnOn();
                }

                if (chance >= 4)
                {
                    this.MotorEngine.Accelerate();
                }
                else
                {
                    this.MotorEngine.Decelerate();
                }

                if (chance >= 9)
                {
                    this.MotorEngine.Brake();
                }

                if (chance > 1 && this.MotorEngine.GetType() == typeof(Broken))
                {
                    this.MotorEngine.Fix();
                }
            }
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("The siren of the patrol car is on.");
        }

        public void SetState(Engine engine)
        {
            this.MotorEngine = engine;
        }

        public Engine GetSate()
        {
            return this.MotorEngine;
        }
    }
}
