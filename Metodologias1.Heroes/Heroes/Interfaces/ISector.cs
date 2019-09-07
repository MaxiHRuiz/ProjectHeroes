namespace Heroes.Interfaces
{
    public interface ISector
    {
        void Wet(double water);

        bool IsOff();

        double GetFireDamage();
    }
}
