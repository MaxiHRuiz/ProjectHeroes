using Heroes.Domain.Place;

namespace Domain.Place
{
    public class ScaredPeopleFactory : FactoryDecorator
    {
        private readonly ISector sector;
        private readonly int scaredPeople;

        public ScaredPeopleFactory(ISector sector, int people)
        {
            this.sector = sector;
            this.scaredPeople = people;
        }

        public override ISector CreateSector()
        {
            return new ScaredPeopleDecorator(sector, scaredPeople);
        }
    }
}