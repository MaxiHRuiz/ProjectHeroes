using System;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class HearthAttackReport : IComplaint
    {
        public IHeartAttack Pedestrian { get; set; }

        public void Attend(IResponsable responsable)
        {
            var handler = (CompliantHandler)responsable;
            handler.TreatingHeartAttack(Pedestrian);
            Console.WriteLine();
            //var doctor = (Medic)responsable;
            //doctor.TreatingHeartAttack(Pedestrian);
        }
    }
}