using Domain.Enums;
using Domain.RandomValue;
using Heroes.Domain.Place;

namespace Domain.Place
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

        public double GetFireDamage()
        {
            return this.FireDamage;
        }

        public override string ToString()
        {
            return "Basic";
        }
    }
}