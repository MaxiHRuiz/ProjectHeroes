using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public class Sector : ISector
    {
        public double FireDamage { get; set; }

        public Sector(double fireDamage)
        {
            this.FireDamage = fireDamage;
        }

        public bool IsOff()
        {
            return this.FireDamage <= 0;
        }

        public void Wet(double water)
        {
            this.FireDamage -= water;
        }
    }
}
