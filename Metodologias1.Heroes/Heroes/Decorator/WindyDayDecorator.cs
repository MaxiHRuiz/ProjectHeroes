using System;
using Heroes.Interfaces;

namespace Heroes.Decorator
{
    class WindyDayDecorator : SectorDecorator
    {
        private readonly ISector sector;
        private readonly int windSpeed;

        public WindyDayDecorator(ISector sector, int wind) : base(sector)
        {
            this.sector = sector;
            this.windSpeed = wind;
        }

        public override void Wet(double water)
        {
            sector.Wet(water - (Math.Exp(windSpeed/100)));
        }

        public override string ToString()
        {
            return "WindyDay, " + sector.ToString();
        }
    }
}
