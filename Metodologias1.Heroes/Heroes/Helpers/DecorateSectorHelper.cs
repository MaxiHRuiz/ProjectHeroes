using System;
using Heroes.Decorator;
using Heroes.Interfaces;

namespace Heroes.Helpers
{
    public static class DecorateSectorHelper
    {
        private static Random random = new Random();

        public static ISector DecorateSector(ISector sector, int rain, int temp, int windSpeed)
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
                sector = new ScaredPeopleDecoratory(sector, scaredPeople);
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
                sector = new RainingDay(sector, rain);
            }

            return sector;
        }

    }
}