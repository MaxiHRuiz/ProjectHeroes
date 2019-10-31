using System;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Application.Heroes
{
    public class Electrician : CompliantHandler, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        public Electrician(CompliantHandler heroe = null) : base(heroe)
        {
            this.Vehicle = new Van();
            this.Tool = new Screwdriver();
        }

        public void Checking()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The electrician will check the lamps...");
            Console.ResetColor();
        }

        public override void changeBurntLamps(IIlluminate place)
        {
            Checking();
            this.Vehicle.GetSate().TurnOn();
            this.Vehicle.TurnOnSiren();
            this.Vehicle.Drive();
            if (this.Vehicle.GetSate().GetType() == typeof(Broken))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nOh no! the electrician's vehicle has broken and now he can not change the lamps.\n");
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
            place.CheckAndChangeBurntLamps();
            this.Tool.PutAway();
        }
    }
}
