using Domain.Place;
using Heroes.Domain.Place;

namespace Domain.Day
{
    public class RainingDayFactory : FactoryDecorator
    {
        private readonly ISector sector;
        private readonly int rainIntensity;

        public RainingDayFactory(ISector sector, int rain)
        {
            this.sector = sector;
            this.rainIntensity = rain;
        }

        public override ISector CreateSector()
        {
            return new RainingDayDecorator(sector, rainIntensity);
        }
    }
}