using System;
using Heroes.Domain.Police;

namespace Application.Heroes
{
    public class Policeman
    {
        private IPoliceOrder command;

        public Policeman(IPoliceOrder command = null)
        {
            this.command = command ?? new StopRightThere();
        }

        public void PatrolStreet(IPatrol place)
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
