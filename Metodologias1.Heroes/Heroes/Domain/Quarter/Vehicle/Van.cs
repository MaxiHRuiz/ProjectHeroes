using System;

namespace Heroes.Domain.Quarter.Vehicle
{
    public class Van : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The electrician is driving the van.");
        }

        public void TurnOnSiren()
        {
            Console.WriteLine("Does the van have a siren?");
        }
    }
}
