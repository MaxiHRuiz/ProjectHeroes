using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.FactoryHeroes
{
    public interface IHeroesFactory
    {
        IResponsable CreateHeroe();

        IVehicle CreateVehicle();

        ITool CreateTool();

        IQuarter CreateQuarter();
    }
}