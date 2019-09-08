using System;
using Application.Places;
using Domain.Enums;
using Domain.Fire;
using Domain.Fireman;
using Domain.Place;

namespace Application.Heroes
{
    public class Firefighter : IFireObserver
    {
        public IExtinguishFire ExtinguishStrategy { get; set; } = new Sequential();

        public void PutOutFire(IPlace place, Street street)
        {
            Enum.TryParse(place.GetType().Name, out PlaceTypeEnum placeType);
            switch (placeType)
            {
                case PlaceTypeEnum.House:
                    ChangeExtinguishStrategy(new Staircase());
                    break;
                case PlaceTypeEnum.Square:
                    ChangeExtinguishStrategy(new Spiral());
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

        public void SoundAlarm(IPlace place, Street street)
        {
            this.PutOutFire(place, street);
        }
    }
}
