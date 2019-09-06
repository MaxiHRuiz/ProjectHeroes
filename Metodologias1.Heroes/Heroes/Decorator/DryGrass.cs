using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class DryGrass : SectorDecorator
    {
        private ISector sector;

        public DryGrass(ISector sector) : base(sector)
        {
            this.sector = sector;
        }

        public override void Wet(double water)
        {
            sector.Wet(water/2);
        }
    }
}
