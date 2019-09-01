using Heroes.Places;

namespace Heroes.Interfaces
{
    public interface IPlace
    {
        Street Street { get; set; }

        int[][] GetFields();

        void Spark();
    }
}