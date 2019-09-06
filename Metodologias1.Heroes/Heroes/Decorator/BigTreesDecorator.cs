using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class BigTreesDecorator : SectorDecorator
    {
        private readonly ISector sector;

        public BigTreesDecorator(ISector sector) : base(sector)
        {
            this.sector = sector;
        }

        public override void Wet(double water)
        {
            sector.Wet(water - (water * 0.25));
        }
    }
}