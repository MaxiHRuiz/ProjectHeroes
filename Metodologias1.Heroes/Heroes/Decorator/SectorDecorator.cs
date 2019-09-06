using Heroes.Interfaces;

namespace Heroes.Decorator
{
    public abstract class SectorDecorator : ISector
    {
        private readonly ISector sector;

        public double FireDamage { get; set; }

        public SectorDecorator(ISector sector)
        {
            this.sector = sector;
        }

        public virtual bool IsOff()
        {
            return this.sector.IsOff();
        }

        public virtual void Wet(double water)
        {
            this.sector.Wet(water);
        }
    }
}