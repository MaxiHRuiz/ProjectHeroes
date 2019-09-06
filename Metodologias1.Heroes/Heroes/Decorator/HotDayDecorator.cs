using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class HotDayDecorator : SectorDecorator
    {
        private readonly ISector sector;
        private readonly int temperature;

        public HotDayDecorator(ISector sector, int temp) : base(sector)
        {
            this.sector = sector;
            this.temperature = temp;
        }

        public override void Wet(double water)
        {
            sector.Wet(water - (this.temperature * 0.1));
        }
    }
}