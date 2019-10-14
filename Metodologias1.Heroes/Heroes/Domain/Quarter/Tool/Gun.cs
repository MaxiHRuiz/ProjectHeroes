using System;

namespace Heroes.Domain.Quarter.Tool
{
    public class Gun : ITool
    {
        public void PutAway()
        {
            Console.WriteLine("the police officer holstered his gun.");
        }

        public void Use()
        {
            Console.WriteLine("The cop is shooting!");
        }
    }
}