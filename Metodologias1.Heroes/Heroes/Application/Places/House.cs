using System;
using System.Collections.Generic;
using Domain.Place;
using Domain.RandomValue;
using Heroes.Domain.Place;
using Heroes.Domain.Place.BuilderDecorator;
using Heroes.Domain.Police;

namespace Application.Places
{
    public class House : IPlace, IFireObserved, IPatrol
    {
        public int Number { get; set; }

        public int Area { get; set; }

        public int Residents { get; set; }

        public Street Street { get; set; }

        public DecoratorBuilder Builder { get; set; }

        public House(int numberHouse, int squareMeters, int numberOfResidents, DecoratorBuilder builder = null)
        {
            this.Number = numberHouse;
            this.Area = squareMeters;
            this.Residents = numberOfResidents;
            this.Builder = builder ?? new BasicBuilder();
        }

        private List<IFireObserver> observers = new List<IFireObserver>();

        public ISector[][] GetFields()
        {
            var squareMeters = Math.Sqrt(this.Area);
            return DecoratorDirector.BuildDecorator(this.Area, this.Builder);
        }

        public void Spark()
        {
            Console.WriteLine($"oh, oh! the {ToString()} is burning!");

            var r = new Random();
            var i = r.Next(this.observers.Count);
            this.observers[i].SoundAlarm(this, this.Street);
        }

        public void AddObserver(IFireObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IFireObserver observer)
        {
            observers.Remove(observer);
        }

        public override string ToString()
        {
            return $"HOUSE N°{this.Number}";
        }

        public bool ThereIsSomethingOutOfOrdinary()
        {
            return GenerateRandomValue.GetRandom(101) >= 70 ? true : false;
        }
    }
}