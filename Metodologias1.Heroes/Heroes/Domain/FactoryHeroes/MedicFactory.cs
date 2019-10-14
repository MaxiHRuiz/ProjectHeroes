using Application.Heroes;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class MedicFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe()
        {
            return new Medic(new RCPTypeA());
        }

        public IQuarter CreateQuarter()
        {
            return Hospital.GetInstance();
        }

        public ITool CreateTool()
        {
            return new Defibrillator();
        }

        public IVehicle CreateVehicle()
        {
            return new Ambulance();
        }
    }
}