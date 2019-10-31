using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Application.Heroes
{
    public class Medic : CompliantHandler, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        public Medic(RCP rcp, CompliantHandler handler = null) : base(handler)
        {
            Rcp = rcp;
            this.Vehicle = new Ambulance();
            this.Tool = new Defibrillator();
        }

        public RCP Rcp { get; set; }

        public override void TreatingHeartAttack(IHeartAttack passerby)
        {
            this.Vehicle.GetSate().TurnOn();
            this.Vehicle.TurnOnSiren();
            this.Vehicle.Drive();
            if (this.Vehicle.GetSate().GetType() == typeof(Broken))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nOh no! the doctor's vehicle has broken and now he can not help the patient.\n");
                Console.ResetColor();
                return;
            }
            else
            {
                // While the vehicle is not at rest, it slows down so that it can be switched off.
                if (this.Vehicle.GetSate().GetType() != typeof(StandOff) && this.Vehicle.GetSate().GetType() != typeof(TurnedOff))
                {
                    this.Vehicle.GetSate().Brake();
                }

                this.Vehicle.GetSate().TurnOff();
                Console.WriteLine(this.Vehicle.GetSate().ToString());
            }

            this.Tool.Use();
            TreatingFainting();
            this.Rcp.AttendHeartAttack(passerby);
            this.Tool.PutAway();
        }

        public void TreatingFainting()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The doctor will treat the fainted patient.\n");
            Console.ResetColor();
        }
    }
}
