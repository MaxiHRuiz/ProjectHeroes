using System;
using Domain.Day;

namespace Domain.Place
{
    public class Sector : ISector
    {
        private static Random random = new Random();

        public double FireDamage { get; set; }

        public Sector(double fireDamage)
        {
            this.FireDamage = fireDamage;
        }

        public bool IsOff()
        {
            return this.FireDamage <= 0;
        }

        public void Wet(double water)
        {
            this.FireDamage -= water;
        }

        public double GetFireDamage()
        {
            return this.FireDamage;
        }

        public ISector DecorateSector(ISector sector, int rain, int temp, int windSpeed)
        {
            double chanceOfDecorate = 0.2;

            if (random.NextDouble() < chanceOfDecorate)
            {
                sector = new DryGrassDecorator(sector);
            }

            if (random.NextDouble() < chanceOfDecorate)
            {
                sector = new BigTreesDecorator(sector);
            }

            if (random.NextDouble() < chanceOfDecorate)
            {
                var scaredPeople = random.Next(0, 6);
                sector = new ScaredPeopleDecorator(sector, scaredPeople);
            }

            if (temp > 30)
            {
                sector = new HotDayDecorator(sector, temp);
            }

            if (windSpeed > 80)
            {
                sector = new WindyDayDecorator(sector, windSpeed);
            }

            if (rain > 0)
            {
                sector = new RainingDayDecorator(sector, rain);
            }

            return sector;
        }

        public override string ToString()
        {
            return "Basic";
        }
    }
}