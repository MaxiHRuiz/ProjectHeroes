using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;

namespace Application.Heroes
{
    public class Medic : IResponsable
    {
        public Medic(RCP rcp, CompliantHandler handler = null)
        {
            Rcp = rcp;
        }

        public RCP Rcp { get; set; }

        public void TreatingHeartAttack(IHeartAttack passerby)
        {
            this.Rcp.AttendHeartAttack(passerby);
        }

        public void TreatingFainting()
        {
            Console.WriteLine("The doctor is treating the fainted patient.");
        }
    }
}
