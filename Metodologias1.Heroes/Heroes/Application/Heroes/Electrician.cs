using System;
using Domain.Place;

namespace Application.Heroes
{
    public class Electrician
    {
        public void Checking(IIlluminate place)
        {
            Console.WriteLine("The electrician is resolving the issue.");
        }

        public void changeBurntLamps(IIlluminate place)
        {
            Console.WriteLine("The electrician is checking the lamps...");
            place.CheckAndChangeBurntLamps();
        }
    }
}
