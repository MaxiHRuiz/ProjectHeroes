using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Application.Heroes
{
    public class Medic : CompliantHandler, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        public Medic(RCP rcp, CompliantHandler handler = null) : base(handler)
        {
            Rcp = rcp;
        }

        public RCP Rcp { get; set; }

        public override void TreatingHeartAttack(IHeartAttack passerby)
        {
            TreatingFainting();
            this.Rcp.AttendHeartAttack(passerby);
            this.Tool.PutAway();
        }

        public void TreatingFainting()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The doctor is treating the fainted patient.\n");
            Console.ResetColor();
            this.Vehicle.Drive();
            this.Vehicle.TurnOnSiren();
            this.Tool.Use();
        }
    }
}
