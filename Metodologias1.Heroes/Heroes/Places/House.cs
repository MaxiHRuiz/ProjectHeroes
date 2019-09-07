using System;
using System.Collections.Generic;
using Heroes.Decorator;
using Heroes.Helpers;
using Heroes.Interfaces;

namespace Heroes.Places
{
    public class House : IPlace, IFireObserved
    {
        public int Number { get; set; }

        public int Area { get; set; }

        public int Residents { get; set; }

        public Street Street { get; set; }

        public House(int numberHouse, int squareMeters, int numberOfResidents)
        {
            this.Number = numberHouse;
            this.Area = squareMeters;
            this.Residents = numberOfResidents;
        }

        private List<IFireObserver> observers = new List<IFireObserver>();

        public ISector[][] GetFields()
        {
            var squareMeters = Math.Sqrt(this.Area);
            var n = (int)Math.Round(squareMeters);
            var random = new Random();

            var fields = new ISector[n][];

            for (int i = 0; i < n; i++)
            {
                fields[i] = new ISector[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int fireDamage = random.Next(101);
                    int temp = random.Next(30, 45);
                    int wind = random.Next(80, 250);
                    int rain = random.Next(1, 500);
                    var sector = new Sector(fireDamage);
                    fields[i][j] = DecorateSectorHelper.DecorateSector(sector, rain, temp, wind);
                }
            }

            return fields;
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

    }
}
