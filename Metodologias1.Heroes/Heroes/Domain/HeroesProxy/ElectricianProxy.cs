using Application.Heroes;
using Heroes.Domain.Compliants;
using Heroes.Domain.FactoryHeroes;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.HeroesProxy
{
    public class ElectricianProxy : IResponsable
    {
        public ElectricianFactory _electricianFactory = null;

        public Electrician CreateHeroe(CompliantHandler handler = null)
        {
            if (_electricianFactory == null)
            {
                _electricianFactory = new ElectricianFactory();
            }

            var eletrician = (Electrician)_electricianFactory.CreateHeroe(handler);
            eletrician.Tool = _electricianFactory.CreateTool();
            eletrician.Vehicle = _electricianFactory.CreateVehicle();

            return eletrician;
        }   
    }
}
