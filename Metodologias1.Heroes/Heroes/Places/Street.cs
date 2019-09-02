using System;
using Heroes.Interfaces;

namespace Heroes.Places
{
    public class Street: IIlluminate
    {
        public int LengthInMeters { get; set; }

        public int Streetlights { get; set; }

        public int WaterFlowPerMinute { get; set; }

        public Street(int lengthMeters, int streetlights, int waterFlowPerMinute)
        {
            this.LengthInMeters = lengthMeters;
            this.Streetlights = streetlights;
            this.WaterFlowPerMinute = waterFlowPerMinute;
        }

        public void CheckAndChangeBurntLamps()
        {
            Console.WriteLine($"The street has {this.Streetlights} lamps to check...");
        }
    }
}
