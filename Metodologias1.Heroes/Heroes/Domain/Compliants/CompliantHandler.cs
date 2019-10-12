using Application.Places;
using Domain.Place;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Police;

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

        public virtual void PutOutFire(IPlace place, Street street)
        {
            if (this.Heroe != null)
                this.Heroe.PutOutFire(place, street);
        }

        public virtual void changeBurntLamps(IIlluminate place)
        {
            if (this.Heroe != null)
                this.Heroe.changeBurntLamps(place);
        }

        public virtual void PatrolStreet(IPatrol place)
        {
            if (this.Heroe != null)
                this.Heroe.PatrolStreet(place);
        }
    }
}
