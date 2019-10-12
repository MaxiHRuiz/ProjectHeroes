using Application.Heroes;
using Domain.Place;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class BurntLampReport : IComplaint
    {
        public IIlluminate Place { get; set; }

        public void Attend(IResponsable responsable)
        {
            var electrician = (Electrician)responsable;
            electrician.changeBurntLamps(Place);
        }
    }
}