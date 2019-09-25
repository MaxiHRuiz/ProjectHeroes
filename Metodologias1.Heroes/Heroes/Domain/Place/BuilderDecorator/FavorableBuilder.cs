using Domain.Enums;
using Domain.Place;
using Domain.RandomValue;

namespace Heroes.Domain.Place
{
    public class FavorableBuilder : DecoratorBuilder
    {
        const double chanceOfDecorate = 0.2;

        public override ISector BuildDecorator()
        {
            int fireDamage = GenerateRandomValue.GetRandom(101);
            int rain = GenerateRandomValue.GetRandom(1, 500);

            ISector sector = new Sector(fireDamage);

            if (rain > 50)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.RainingDay, rain);
            }

            return sector;
        }
    }
}