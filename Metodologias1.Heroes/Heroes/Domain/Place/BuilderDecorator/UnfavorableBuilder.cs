using Domain.Enums;
using Domain.Place;
using Domain.RandomValue;

namespace Heroes.Domain.Place
{
    public class UnfavorableBuilder : DecoratorBuilder
    {
        const double chanceOfDecorate = 0.2;

        public override ISector BuildDecorator()
        {
            int fireDamage = GenerateRandomValue.GetRandom(101);
            int temp = GenerateRandomValue.GetRandom(30, 45);
            int windSpeed = GenerateRandomValue.GetRandom(80, 250);

            ISector sector = new Sector(fireDamage);

            if (GenerateRandomValue.NextDouble() < chanceOfDecorate)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.DryGrass);
            }

            if (GenerateRandomValue.NextDouble() < chanceOfDecorate)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.BigTrees);
            }

            if (GenerateRandomValue.NextDouble() < chanceOfDecorate)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.ScaredPeople);
            }

            if (temp > 30)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.HotDay, temp);
            }

            if (windSpeed > 80)
            {
                sector = FactoryDecorator.CreateDecorator(sector, DecoratorTypeEnum.WindyDay, windSpeed);
            }

            return sector;
        }
    }
}