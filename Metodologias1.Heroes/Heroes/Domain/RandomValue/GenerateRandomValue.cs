using System;

namespace Domain.RandomValue
{
    public static class GenerateRandomValue
    {
        private static Random random = new Random();

        public static int GetRandom()
        {
            return random.Next();
        }

        public static int GetRandom(int maxValue)
        {
            return random.Next(maxValue);
        }

        public static int GetRandom(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public static double NextDouble()
        {
            return random.NextDouble();
        }
    }
}