namespace Heroes.Domain.Quarter.Vehicle
{
    public interface IVehicle
    {
        void TurnOnSiren();

        void Drive();

        void SetState(Engine engine);

        Engine GetSate();
    }
}
