using System;
using Application.Places;
using Domain.Enums;
using Domain.Fire;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Enums;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Application.Heroes
{
    public class Firefighter : CompliantHandler, IFireObserver, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        public IExtinguishFire ExtinguishStrategy { get; set; } = new SequentialStrategy();

        public Firefighter(CompliantHandler handler = null) : base(handler) { }

        public override void PutOutFire(IPlace place, Street street)
        {
            Enum.TryParse(place.GetType().Name, out PlaceTypeEnum placeType);
            switch (placeType)
            {
                case PlaceTypeEnum.House:
                    ChangeExtinguishStrategy(new StaircaseStrategy());
                    break;
                case PlaceTypeEnum.Square:
                    ChangeExtinguishStrategy(new SpiralStrategy());
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The fireman will put out the fire...\n");
            Console.ResetColor();

            this.Vehicle.GetSate().TurnOn();
            this.Vehicle.TurnOnSiren();
            this.Vehicle.Drive();
            if (this.Vehicle.GetSate().GetType() == typeof(Broken))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nOh no! the fireman's vehicle has broken and now he can not put out the fire.\n");
                Console.ResetColor();
                return;
            }
            else
            {
                // While the vehicle is not at rest, it slows down so that it can be switched off.
                if (this.Vehicle.GetSate().GetType() != typeof(StandOff) && this.Vehicle.GetSate().GetType() != typeof(TurnedOff))
                {
                    this.Vehicle.GetSate().Brake();
                }

                this.Vehicle.GetSate().TurnOff();
                Console.WriteLine(this.Vehicle.GetSate().ToString());
            }

            this.Tool.Use();
            this.ExtinguishStrategy.ExtinguishFire(place.GetFields(), street.WaterFlowPerMinute);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nThe fire at {place.ToString()} was put out!!!\n");
            Console.ResetColor();

            this.Tool.PutAway();
        }

        public void GetCatOutOfTree()
        {
            Console.WriteLine("The fireman is helping the cat down.");
        }

        public void ChangeExtinguishStrategy(IExtinguishFire strategy)
        {
            this.ExtinguishStrategy = strategy;
            Console.WriteLine($"Strategy changed to {strategy.ToString()}.");
        }

        public void SoundAlarm(IPlace place)
        {
            this.PutOutFire(place, place.Street);
        }
    }
}
