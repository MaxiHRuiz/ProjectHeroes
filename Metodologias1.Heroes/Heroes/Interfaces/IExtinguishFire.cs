namespace Heroes.Interfaces
{
    public interface IExtinguishFire
    {
        void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute);
    }
}
