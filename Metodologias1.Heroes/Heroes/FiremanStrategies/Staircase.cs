using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.FiremanStrategies
{
    public class Staircase : IExtinguishFire
    {
        public void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute)
        {
            var goToLeft = false;
            var goToRight = true;

            for (int i = 0; i < squareMeters.Length; i++)
            {
                if (goToRight)
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

                    goToRight = false;
                    goToLeft = true;
                    continue;
                }

                if (goToLeft)
                {
                    for (int j = squareMeters[i].Length - 1; j >= 0; j--)
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

                    goToRight = true;
                    goToLeft = false;
                    continue;
                }
            }
        }
    }
}
