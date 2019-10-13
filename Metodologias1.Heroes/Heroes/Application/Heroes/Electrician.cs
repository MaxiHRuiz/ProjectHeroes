using System;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;

namespace Application.Heroes
{
    public class Electrician : CompliantHandler, IResponsable
    {
        public Electrician(CompliantHandler heroe = null) : base(heroe) { }

        public void Checking(IIlluminate place)
        {
            Console.WriteLine("The electrician is resolving the issue.");
        }

        public override void changeBurntLamps(IIlluminate place)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The electrician is checking the lamps...");
            Console.ResetColor();
            place.CheckAndChangeBurntLamps();
        }
    }
}
