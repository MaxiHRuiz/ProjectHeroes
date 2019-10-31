using System;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman;
using Heroes.Domain.Police;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;
using Heroes.Domain.Quarter.Vehicle.State;

namespace Application.Heroes
{
    public class Cop : CompliantHandler, IResponsable
    {
        public ITool Tool { get; set; }

        public IVehicle Vehicle { get; set; }

        private IPoliceOrder command;

        public Cop(IPoliceOrder command = null, CompliantHandler heroe = null) : base(heroe)
        {
            this.command = command ?? new StopRightThere();
            this.Vehicle = new PolicePatrolCar();
            this.Tool = new Gun();
        }

        public override void PatrolStreet(IPatrol place)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The cop wil patroll the streets...");
            Console.ResetColor();

            this.Vehicle.GetSate().TurnOn();
            this.Vehicle.TurnOnSiren();
            this.Vehicle.Drive();
            if (this.Vehicle.GetSate().GetType() == typeof(Broken))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nOh no! the cop's vehicle has broken and now he can not patrol the streets.\n");
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
            if (place.ThereIsSomethingOutOfOrdinary())
            {
                this.Tool.Use();
                this.command.Execute();
                this.Tool.PutAway();
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
            Console.WriteLine($"Command changed to {command.ToString()}.");
        }
    }
}
