using Heroes.Places;

namespace Heroes.Interfaces
{
    public interface IPlace
    {
        Street Street { get; set; }

        ISector[][] GetFields();

        void Spark();
    }
}