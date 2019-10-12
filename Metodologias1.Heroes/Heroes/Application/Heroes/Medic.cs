using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;

namespace Application.Heroes
{
    public class Medic : CompliantHandler, IResponsable
    {
        public Medic(RCP rcp, CompliantHandler handler = null): base(handler)
        {
            Rcp = rcp;
        }

        public RCP Rcp { get; set; }

        public override void TreatingHeartAttack(IHeartAttack passerby)
        {
            TreatingFainting();
            this.Rcp.AttendHeartAttack(passerby);
        }

        public void TreatingFainting()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The doctor is treating the fainted patient.");
            Console.ResetColor();
        }
    }
}
