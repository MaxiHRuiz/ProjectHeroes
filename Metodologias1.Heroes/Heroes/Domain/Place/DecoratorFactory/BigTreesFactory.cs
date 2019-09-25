using Heroes.Domain.Place;

namespace Domain.Place
{
    public class BigTreesFactory : FactoryDecorator
    {
        private readonly ISector sector;

        public BigTreesFactory(ISector sector)
        {
            this.sector = sector;
        }

        public override ISector CreateSector()
        {
            return new BigTreesDecorator(sector);
        }
    }
}