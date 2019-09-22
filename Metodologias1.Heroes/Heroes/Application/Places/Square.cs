using System;
using System.Collections.Generic;
using Domain.Place;
using Domain.RandomValue;
using Heroes.Domain.Place;
using Heroes.Domain.Place.BuilderDecorator;
using Heroes.Domain.Police;

namespace Application.Places
{
    public class Square : IPlace, IFireObserved, IIlluminate, IPatrol
    {
        public string Name { get; set; }

        public double Area { get; set; }

        public int Trees { get; set; }

        public int Streetlights { get; set; }

        public Street Street { get; set; }

        public DecoratorBuilder Builder { get; set; }

        private List<IFireObserver> observers = new List<IFireObserver>();
        
        public Square(string squareName, double lengthMeters, int trees, int streetlights, DecoratorBuilder builder = null)
        {
            this.Name = squareName;
            this.Area = lengthMeters;
            this.Trees = trees;
            this.Streetlights = streetlights;
            this.Builder = builder ?? new BasicBuilder();
        }

        public ISector[][] GetFields()
        {
            var squareMeters = Math.Sqrt(this.Area);
            return DecoratorDirector.BuildDecorator(this.Area, this.Builder);
        }

        public void Spark()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"oh, oh! the {ToString()} is burning!");
            Console.ResetColor();

            Random r = new Random();
            var i = r.Next(this.observers.Count);
            this.observers[i].SoundAlarm(this, this.Street);
        }

        public void AddObserver(IFireObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IFireObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void CheckAndChangeBurntLamps()
        {
            Console.WriteLine($"The {this.ToString()} has {this.Streetlights} lamps to check...");
        }

        public override string ToString()
        {
            return $"{this.Name.ToUpper()}, SQUARE";
        }

        public bool ThereIsSomethingOutOfOrdinary()
        {
            return GenerateRandomValue.GetRandom(101) >= 50 ? true : false;
        }
    }
}
