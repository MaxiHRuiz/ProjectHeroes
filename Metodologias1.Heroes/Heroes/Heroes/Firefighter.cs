using System;
using Heroes.FiremanStrategies;
using Heroes.Helpers;
using Heroes.Interfaces;
using Heroes.Places;

namespace Heroes.Heroes
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
            Console.WriteLine("The fireman is putting out the fire...");
            this.ExtinguishStrategy.ExtinguishFire(place.GetFields(), street.WaterFlowPerMinute);
            Console.WriteLine($"The fire at {place.ToString()} was put out!!!");
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
