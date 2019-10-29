using Application.Heroes;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class CopFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe(CompliantHandler handler = null)
        {
            return new Cop(heroe: handler);
        }

        public IQuarter CreateQuarter()
        {
            return PoliceStation.GetInstance();
        }

        public ITool CreateTool()
        {
            return new Gun();
        }

        public IVehicle CreateVehicle()
        {
            return new PolicePatrolCar();
        }
    }
}