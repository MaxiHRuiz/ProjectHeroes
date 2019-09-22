namespace Domain.Place
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

        public override string ToString()
        {
            return "BigTrees, " + sector.ToString();
        }
    }
}