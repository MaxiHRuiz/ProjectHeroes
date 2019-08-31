using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.FiremanStrategies
{
    public class Staircase : IExtinguishFire
    {
        public void ExtinguishFire(int[][] squareMeters, int waterFlowPerMinute)
        {
            var goToLeft = false;
            var goToRight = true;

            for (int i = 0; i < squareMeters.Length; i++)
            {
                if (goToRight)
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

                    goToRight = false;
                    goToLeft = true;
                    continue;
                }

                if (goToLeft)
                {
                    for (int j = squareMeters[i].Length - 1; j >= 0; j--)
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

                    goToRight = true;
                    goToLeft = false;
                    continue;
                }
            }
        }
    }
}
