using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.FiremanStrategies
{
    public class Sequential : IExtinguishFire
    {
        public void ExtinguishFire(int[][] squareMeters, int waterFlowPerMinute)
        {
            for (int i = 0; i < squareMeters.Length; i++)
            {
                for (int j = 0; j < squareMeters[i].Length; j++)
                {
                    var quantityLeft = new List<int>();
                    quantityLeft.Add(squareMeters[i][j]);

                    while (squareMeters[i][j] > 0)
                    {
                        squareMeters[i][j] -= waterFlowPerMinute;
                        if (squareMeters[i][j] < 0)
                        {
                            quantityLeft.Add(0);
                        }
                        else
                        {
                            quantityLeft.Add(squareMeters[i][j]);
                        }
                    }

                    Console.WriteLine($"({i},{j}) -> " + string.Join(" -> ", quantityLeft));
                }
            }
        }
    }
}
