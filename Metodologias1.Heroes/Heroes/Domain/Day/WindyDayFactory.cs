using Domain.Place;
using Heroes.Domain.Place;

namespace Domain.Day
{
    class WindyDayFactory : FactoryDecorator
    {
        private readonly ISector sector;
        private readonly int wind;

        public WindyDayFactory(ISector sector, int wind)
        {
            this.sector = sector;
            this.wind = wind;
        }

        public override ISector CreateSector()
        {
            return new WindyDayDecorator(sector, wind);
        }
    }
}