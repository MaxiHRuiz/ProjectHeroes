using Application.Places;

namespace Domain.Place
{
    public interface IPlace
    {
        Street Street { get; set; }

        ISector[][] GetFields();

        void Spark();
    }
}