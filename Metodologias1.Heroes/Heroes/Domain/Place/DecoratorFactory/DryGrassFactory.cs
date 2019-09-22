using Heroes.Domain.Place;

namespace Domain.Place
{
    public class DryGrassFactory : FactoryDecorator
    {
        private readonly ISector sector;

        public DryGrassFactory(ISector sector)
        {
            this.sector = sector;
        }

        public override ISector CreateSector()
        {
            return new DryGrassDecorator(sector);
        }
    }
}