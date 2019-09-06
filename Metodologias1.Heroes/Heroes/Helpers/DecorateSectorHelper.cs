using System;
using Heroes.Decorator;
using Heroes.Interfaces;

namespace Heroes.Helpers
{
    public static class DecorateSectorHelper
    {
        public static ISector DecorateSector(ISector sector, int rain, int temp, int windSpeed)
        {
            var random = new Random();
            double chanceOfDecorate = 0.2;

            if (random.NextDouble() < chanceOfDecorate)
            {
                sector = new DryGrass(sector);
            }
            if (random.NextDouble() < chanceOfDecorate)
            {
                sector = new BigTreesDecorator(sector);
            }
            if (random.NextDouble() < chanceOfDecorate)
            {
                sector = new HotDayDecorator(sector, temp);
            }

            return sector;
        }
    }
}