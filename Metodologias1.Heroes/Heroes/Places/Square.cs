using System;
using Heroes.Interfaces;

namespace Heroes.Places
{
    public class Square : IPlace
    {
        public string Name { get; set; }

        public double Area { get; set; }

        public int Trees { get; set; }

        public int Streetlights { get; set; }

        public Square(string squareName, double lengthMeters, int trees, int streetlights)
        {
            this.Name = squareName;
            this.Area = lengthMeters;
            this.Trees = trees;
            this.Streetlights = streetlights;
        }

        public int[][] GetFields()
        {
            var squareMeters = Math.Sqrt(this.Area);
            var n = (int)Math.Round(squareMeters);
            var random = new Random();

            var fields = new int[n][];

            for (int i = 0; i < n; i++)
            {
                fields[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    fields[i][j] = random.Next(101);
                }

            }

            return fields;
        }

        public override string ToString()
        {
            return "SQUARE";
        }
    }
}
