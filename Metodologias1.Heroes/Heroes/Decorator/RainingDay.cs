using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class RainingDay : SectorDecorator
    {
        private ISector sector;
        private int rainIntensity;

        public RainingDay(ISector sector, int rainIntensity) : base(sector)
        {
            this.sector = sector;
            this.rainIntensity = rainIntensity;
        }

        public override void Wet(double water)
        {
            sector.Wet(water + rainIntensity);
        }

        public override string ToString()
        {
            return "RainingDay, " + sector.ToString();
        }
    }
}
