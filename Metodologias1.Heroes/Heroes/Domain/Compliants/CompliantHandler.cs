using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public abstract class CompliantHandler : IResponsable
    {
        public CompliantHandler Heroe { get; set; }

        public CompliantHandler(CompliantHandler heroe)
        {
            this.Heroe = heroe;
        }

        public virtual void TreatingHeartAttack(IHeartAttack passerby)
        {
            if (this.Heroe != null)
                this.Heroe.TreatingHeartAttack(passerby);
        }
    }
}
