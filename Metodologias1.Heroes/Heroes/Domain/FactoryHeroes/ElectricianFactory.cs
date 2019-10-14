using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class ElectricianFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe()
        {
            return new Electrician();
        }

        public IQuarter CreateQuarter()
        {
            return new ElectricPlant();
        }

        public ITool CreateTool()
        {
            return new Screwdriver();
        }

        public IVehicle CreateVehicle()
        {
            return new Van();
        }
    }
}