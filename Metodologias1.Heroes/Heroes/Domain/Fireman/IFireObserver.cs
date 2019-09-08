using Application.Places;

namespace Domain.Place
{
    public interface IFireObserver
    {
        void SoundAlarm(IPlace place, Street street);
    }
}