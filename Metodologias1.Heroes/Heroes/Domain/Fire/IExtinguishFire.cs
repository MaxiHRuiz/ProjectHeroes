using Domain.Place;

namespace Domain.Fire
{
    public interface IExtinguishFire
    {
        void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute);
    }
}
