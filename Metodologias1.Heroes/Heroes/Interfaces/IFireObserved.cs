using Heroes.Heroes;

namespace Heroes.Interfaces
{
    public interface IFireObserved
    {
        void AddObserver(IFireObserver observer);

        void RemoveObserver(IFireObserver observer);
    }
}
