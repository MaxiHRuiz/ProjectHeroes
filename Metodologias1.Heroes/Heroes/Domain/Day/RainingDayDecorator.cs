using Domain.Place;

namespace Domain.Day
{
    public class RainingDayDecorator : SectorDecorator
    {
        private ISector sector;
        private int rainIntensity;

        public RainingDayDecorator(ISector sector, int rainIntensity) : base(sector)
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