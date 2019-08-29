namespace Heroes.Places
{
    public class Street
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
    }
}
