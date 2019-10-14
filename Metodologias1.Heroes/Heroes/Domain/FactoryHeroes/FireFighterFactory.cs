using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class FireFighterFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe()
        {
            return new Firefighter();
        }

        public IQuarter CreateQuarter()
        {
            return new FireStation();
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