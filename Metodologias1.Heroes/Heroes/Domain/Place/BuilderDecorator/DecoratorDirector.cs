using System;
using Domain.Place;

namespace Heroes.Domain.Place.BuilderDecorator
{
    public class DecoratorDirector
    {
        public static ISector[][] BuildDecorator(double squareMeters, DecoratorBuilder builder)
        {
            var area = Math.Sqrt(squareMeters);
            var n = (int)Math.Round(area);
            var fields = new ISector[n][];

            for (int i = 0; i < n; i++)
            {
                fields[i] = new ISector[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    fields[i][j] = builder.BuildDecorator();
                }
            }

            return fields;
        }
    }
}
