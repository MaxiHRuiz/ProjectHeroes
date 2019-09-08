using Domain.Fireman;

namespace Domain.Place
{
    public interface IFireObserved
    {
        void AddObserver(IFireObserver observer);

        void RemoveObserver(IFireObserver observer);
    }
}