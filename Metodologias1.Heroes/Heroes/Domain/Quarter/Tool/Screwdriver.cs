using System;

namespace Heroes.Domain.Quarter.Tool
{
    public class Screwdriver : ITool
    {
        public void PutAway()
        {
            Console.WriteLine("the electrician is putting away his tool.");
        }

        public void Use()
        {
            Console.WriteLine("the electrician is using the screwdriver.");
        }
    }
}