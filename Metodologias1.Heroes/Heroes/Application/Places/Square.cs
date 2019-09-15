using System;
using System.Collections.Generic;
using Domain.Place;
using Domain.RandomValue;
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

        private List<IFireObserver> observers = new List<IFireObserver>();

        public Square(string squareName, double lengthMeters, int trees, int streetlights)
        {
            this.Name = squareName;
            this.Area = lengthMeters;
            this.Trees = trees;
            this.Streetlights = streetlights;
        }

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
                    int fireDamage = random.Next(100);
                    int temp = random.Next(30, 45);
                    int wind = random.Next(80, 250);
                    int rain = random.Next(1, 500);
                    var sector = new Sector(fireDamage);
                    fields[i][j] = sector.DecorateSector(sector, rain, temp, wind);
                }
            }

            return fields;
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
