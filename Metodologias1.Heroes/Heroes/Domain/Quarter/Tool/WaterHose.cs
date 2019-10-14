using System;

namespace Heroes.Domain.Quarter.Tool
{
    public class WaterHose : ITool
    {
        public void PutAway()
        {
            Console.WriteLine("The firefighter is putting away his water hose.");
        }

        public void Use()
        {
            Console.WriteLine("The firefighter is using his water hose!!!");
        }
    }
}