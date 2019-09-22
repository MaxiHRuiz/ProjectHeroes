using Domain.Day;
using Domain.Enums;
using Domain.Place;
using Domain.RandomValue;

namespace Heroes.Domain.Place
{
    public abstract class FactoryDecorator
    {
        public static ISector CreateDecorator(ISector sector, DecoratorTypeEnum type, int value = 0)
        {
            FactoryDecorator sectorFactory = null;

            switch (type)
            {
                case DecoratorTypeEnum.BigTrees:
                    sectorFactory = new BigTreesFactory(sector);
                    break;
                case DecoratorTypeEnum.DryGrass:
                    sectorFactory = new DryGrassFactory(sector);
                    break;
                case DecoratorTypeEnum.HotDay:
                    sectorFactory = new HotDayFactory(sector, value);
                    break;
                case DecoratorTypeEnum.RainingDay:
                    sectorFactory = new RainingDayFactory(sector, value);
                    break;
                case DecoratorTypeEnum.ScaredPeople:
                    var scaredPeople = GenerateRandomValue.GetRandom(0, 6);
                    sectorFactory = new ScaredPeopleFactory(sector, scaredPeople);
                    break;
                case DecoratorTypeEnum.WindyDay:
                    sectorFactory = new WindyDayFactory(sector, value);
                    break;
                case DecoratorTypeEnum.Basic:
                    sectorFactory = new BasicFactory(sector);
                    break;
            }

            return sectorFactory.CreateSector();
        }

        public abstract ISector CreateSector();
    }
}