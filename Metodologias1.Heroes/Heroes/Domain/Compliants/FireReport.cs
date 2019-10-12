using Application.Heroes;
using Domain.Place;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class FireReport : IComplaint
    {
        public IPlace Place { get; set; }

        public FireReport(IPlace place)
        {
            this.Place = place;
        }
        
        public void Attend(IResponsable responsable)
        {
            var fireman = (Firefighter)responsable;
            fireman.PutOutFire(Place, Place.Street);
        }
    }
}