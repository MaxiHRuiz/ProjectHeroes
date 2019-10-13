using System;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Application.Heroes
{
    public class Electrician : CompliantHandler, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        public Electrician(CompliantHandler heroe = null) : base(heroe) { }

        public void Checking()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The electrician is checking the lamps...");
            Console.ResetColor();
            this.Vehicle.Drive();
            this.Vehicle.TurnOnSiren();
            this.Tool.Use();
        }

        public override void changeBurntLamps(IIlluminate place)
        {
            Checking();
            place.CheckAndChangeBurntLamps();
            this.Tool.PutAway();
        }
    }
}
