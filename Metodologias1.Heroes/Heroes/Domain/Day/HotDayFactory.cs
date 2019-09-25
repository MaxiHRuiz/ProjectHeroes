using Domain.Place;
using Heroes.Domain.Place;

namespace Domain.Day
{
    public class HotDayFactory : FactoryDecorator
    {
        private readonly ISector sector;
        private readonly int temperature;

        public HotDayFactory(ISector sector, int temp)
        {
            this.sector = sector;
            this.temperature = temp;
        }

        public override ISector CreateSector()
        {
            return new HotDayDecorator(this.sector, this.temperature);
        }
    }
}