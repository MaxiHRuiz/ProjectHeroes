namespace Heroes.Interfaces
{
    public interface ISector
    {
        double FireDamage { get; set; }

        void Wet(double water);

        bool IsOff();
    }
}
