using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public class MedicFactory : IHeroesFactory
    {
        public IResponsable CreateHeroe(CompliantHandler handler = null)
        {
            return new Application.Heroes.Medic(new RCPTypeA(), handler);
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