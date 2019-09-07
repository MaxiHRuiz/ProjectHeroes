using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class ScaredPeopleDecoratory : SectorDecorator
    {
        private ISector sector;

        // El decorado “gente asustada” tendrá un parámetro cantidad de personas(entre 0 y 5) que restará el 75% al valor de agua recibido.
        private int people;

        public ScaredPeopleDecoratory(ISector sector, int scaredPeople) : base(sector)
        {
            this.sector = sector;
            this.people = scaredPeople;
        }

        public override void Wet(double water)
        {
            water = this.people == 5 ? (water - (water * 0.75)) : water;
            this.sector.Wet(water);
        }

        public override string ToString()
        {
            return "ScaredPeople, " + sector.ToString();
        }
    }
}