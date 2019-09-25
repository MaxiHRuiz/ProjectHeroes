using Heroes.Domain.Place;

namespace Domain.Place
{
    public class BasicFactory : FactoryDecorator
    {
        private readonly ISector sector;

        public BasicFactory(ISector sector)
        {
            this.sector = sector;
        }

        public override ISector CreateSector()
        {
            return sector;
        }
    }
}