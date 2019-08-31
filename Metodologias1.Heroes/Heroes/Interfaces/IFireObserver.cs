using Heroes.Places;

namespace Heroes.Interfaces
{
    public interface IFireObserver
    {
        void PutOutFire(IPlace place, Street street);
    }
}
