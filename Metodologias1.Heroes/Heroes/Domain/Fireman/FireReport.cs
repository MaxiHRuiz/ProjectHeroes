using Application.Heroes;
using Domain.Place;

namespace Heroes.Domain.Fireman
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