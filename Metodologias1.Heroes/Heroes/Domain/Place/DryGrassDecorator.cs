namespace Domain.Place
{
    public class DryGrassDecorator : SectorDecorator
    {
        private ISector sector;

        public DryGrassDecorator(ISector sector) : base(sector)
        {
            this.sector = sector;
        }

        public override void Wet(double water)
        {
            sector.Wet(water/2);
        }

        public override string ToString()
        {
            return "DryGrass, " + sector.ToString();
        }
    }
}