namespace Heroes.Places
{
    public class House
    {
        public int Number { get; set; }

        public int SquareMeters { get; set; }

        public int Residents { get; set; }

        public House(int numberHouse, int squareMeters, int numberOfResidents)
        {
            this.Number = numberHouse;
            this.SquareMeters = squareMeters;
            this.Residents = numberOfResidents;
        }
    }
}
