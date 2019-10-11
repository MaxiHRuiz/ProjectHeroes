using System;
using Application.Places;
using Domain.Enums;
using Domain.Fire;
using Domain.Place;
using Heroes.Domain.Fireman;

namespace Application.Heroes
{
    public class Firefighter : IFireObserver, IResponsable
    {
        public IExtinguishFire ExtinguishStrategy { get; set; } = new SequentialStrategy();

        public void PutOutFire(IPlace place, Street street)
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
            Console.WriteLine("The fireman is putting out the fire...\n");
            this.ExtinguishStrategy.ExtinguishFire(place.GetFields(), street.WaterFlowPerMinute);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nThe fire at {place.ToString()} was put out!!!");
        }

        public void GetCatOutOfTree()
        {
            Console.WriteLine("The fireman is helping the cat down.");
        }

        public void ChangeExtinguishStrategy(IExtinguishFire strategy)
        {
            this.ExtinguishStrategy = strategy;
        }

        public void SoundAlarm(IPlace place)
        {
            this.PutOutFire(place, place.Street);
        }
    }
}
