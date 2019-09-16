using System;
using Heroes.Domain.Doctor;

namespace Application.Heroes
{
    public class Doctor
    {
        public Doctor(RCP rcp)
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
