using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.FiremanStrategies
{
    public class Sequential : IExtinguishFire
    {
        public void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute)
        {
            for (int i = 0; i < squareMeters.Length; i++)
            {
                for (int j = 0; j < squareMeters[i].Length; j++)
                {
                    var quantityLeft = new List<double>();
                    quantityLeft.Add(squareMeters[i][j].FireDamage);

                    while (!squareMeters[i][j].IsOff())
                    {
                        squareMeters[i][j].Wet(waterFlowPerMinute);
                        if (squareMeters[i][j].IsOff())
                        {
                            quantityLeft.Add(0);
                        }
                        else
                        {
                            quantityLeft.Add(squareMeters[i][j].FireDamage);
                        }
                    }

                    Console.WriteLine($"({i},{j}) -> " + string.Join(" -> ", quantityLeft));
                }
            }
        }
    }
}
