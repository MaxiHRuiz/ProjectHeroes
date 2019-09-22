using Domain.Enums;
using Domain.Place;
using Domain.RandomValue;

namespace Heroes.Domain.Place
{
    public class BasicBuilder : DecoratorBuilder
    {
        public override ISector BuildDecorator()
        {
            int fireDamage = GenerateRandomValue.GetRandom(101);
            var sector = new Sector(fireDamage);
            return FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.Basic);
        }
    }
}