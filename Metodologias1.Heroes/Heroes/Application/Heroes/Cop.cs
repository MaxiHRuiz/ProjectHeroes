using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Police;

namespace Application.Heroes
{
    public class Cop : CompliantHandler, IResponsable
    {
        private IPoliceOrder command;

        public Cop(IPoliceOrder command = null, CompliantHandler heroe = null) : base(heroe)
        {
            this.command = command ?? new StopRightThere();
        }

        public override void PatrolStreet(IPatrol place)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The cop is patrolling the streets...");
            Console.ResetColor();

            if (place.ThereIsSomethingOutOfOrdinary())
            {
                this.command.Execute();
            }
            else
            {
                Console.WriteLine("There is nothing out of the ordinary.");
            }
        }

        public void ArrestCriminal()
        {
            Console.WriteLine("The cop is arresting a criminal.");
        }

        public void ChangeOrder(IPoliceOrder command)
        {
            this.command = command;
        }
    }
}
