using System;
using Heroes.Interfaces;

namespace Heroes.Places
{
    public class House : IPlace
    {
        public int Number { get; set; }

        public int Area { get; set; }

        public int Residents { get; set; }

        public House(int numberHouse, int squareMeters, int numberOfResidents)
        {
            this.Number = numberHouse;
            this.Area = squareMeters;
            this.Residents = numberOfResidents;
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
            return "HOUSE";
        }
    }
}
