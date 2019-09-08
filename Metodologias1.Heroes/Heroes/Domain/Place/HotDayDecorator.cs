namespace Domain.Place
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

        public override string ToString()
        {
            return "HotDay, " + sector.ToString();
        }
    }
}