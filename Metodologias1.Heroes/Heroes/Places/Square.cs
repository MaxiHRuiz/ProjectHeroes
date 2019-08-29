namespace Heroes.Places
{
    public class Square
    {
        public string Name { get; set; }

        public double SquareMeters { get; set; }

        public int Trees { get; set; }

        public int Streetlights { get; set; }

        public Square(string squareName, double squareMeters, int trees, int streetlights)
        {
            this.Name = squareName;
            this.SquareMeters = squareMeters;
            this.Trees = trees;
            this.Streetlights = streetlights;
        }
    }
}
