using System;
using System.Collections.Generic;
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

        public int[][] GetFields()
        {
            var squareMeters = Math.Sqrt(this.Area);
            var n = (int)Math.Round(squareMeters);
            var random = new Random();

            var fields = new int[n][];

            for (int i = 0; i < n; i++)
            {
                fields[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    fields[i][j] = random.Next(101);
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
