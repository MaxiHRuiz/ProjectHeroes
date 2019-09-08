using Application.Places;
using Domain.Place;

namespace Domain.Fireman
{
    public interface IFireObserver
    {
        void SoundAlarm(IPlace place, Street street);
    }
}