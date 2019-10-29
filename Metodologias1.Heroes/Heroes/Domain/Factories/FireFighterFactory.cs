using Application.Heroes;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class FireFighterFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe(CompliantHandler handler)
        {
            return new Firefighter(handler);
        }

        public IQuarter CreateQuarter()
        {
            return FireStation.GetInstance();
        }

        public ITool CreateTool()
        {
            return new WaterHose();
        }

        public IVehicle CreateVehicle()
        {
            return new FireTruck();
        }
    }
}