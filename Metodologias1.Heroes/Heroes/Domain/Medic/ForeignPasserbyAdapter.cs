using HeroesDeCiudad;

namespace Heroes.Domain.Doctor
{
    public class ForeignPasserbyAdapter : IHeartAttack
    {
        public ForeignPasserbyAdapter(ForeignPasserby passerby)
        {
            Passerby = passerby;
        }

        public ForeignPasserby Passerby { get; set; }

        public bool IsAware()
        {
            return Passerby.isConscious();
        }

        public bool IsBreathing()
        {
            return Passerby.isBreathing();
        }

        public bool ItHasHeartRhythm()
        {
            return Passerby.haveHeartRate();
        }
    }
}