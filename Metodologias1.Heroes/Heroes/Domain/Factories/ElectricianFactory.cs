using Application.Heroes;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class ElectricianFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe(CompliantHandler handler = null)
        {
            return new Electrician(handler);
        }

        public IQuarter CreateQuarter()
        {
            return ElectricPlant.GetInstance();
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