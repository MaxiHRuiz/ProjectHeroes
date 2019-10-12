using Application.Heroes;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class HearthAttackReport : IComplaint
    {
        public IHeartAttack Pedestrian { get; set; }

        public void Attend(IResponsable responsable)
        {
            var doctor = (Medic)responsable;
            doctor.TreatingHeartAttack(Pedestrian);
        }
    }
}