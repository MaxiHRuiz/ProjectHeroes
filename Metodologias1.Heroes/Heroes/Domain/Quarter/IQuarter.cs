using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.Quarter
{
    public interface IQuarter
    {
        void AddVehicle(IVehicle vehicle);

        void AddResponsable(IResponsable heroe);

        void AddTool(ITool tool);

        IResponsable GetPersonal();
    }
}