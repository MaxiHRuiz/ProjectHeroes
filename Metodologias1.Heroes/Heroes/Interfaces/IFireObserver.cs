using Heroes.Places;

namespace Heroes.Interfaces
{
    public interface IFireObserver
    {
        void SoundAlarm(IPlace place, Street street);
    }
}
