using System;

namespace Heroes.Domain.Quarter.Tool
{
    public class Defibrillator : ITool
    {
        public void PutAway()
        {
            Console.WriteLine("The medic is storing his defibrillator in his backpackage.");
        }

        public void Use()
        {
            Console.WriteLine("The medic is using the defibrillator.");
        }
    }
}