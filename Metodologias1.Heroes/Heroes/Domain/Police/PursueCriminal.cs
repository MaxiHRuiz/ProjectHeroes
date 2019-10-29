using System;

namespace Heroes.Domain.Police
{
    public class PursueCriminal : IPoliceOrder
    {
        public void Execute()
        {
            Console.WriteLine("The cop is chasing a criminal!");
        }

        public override string ToString()
        {
            return "Pursue Criminal";
        }
    }
}