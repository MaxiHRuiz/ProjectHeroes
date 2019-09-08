using System;
using System.Collections.Generic;
using Domain.Place;

namespace Domain.Fire
{
    public class StaircaseStrategy : IExtinguishFire
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
                        var remainingFireList = new List<double>();
                        remainingFireList.Add(squareMeters[i][j].GetFireDamage());

                        while (!squareMeters[i][j].IsOff())
                        {
                            squareMeters[i][j].Wet(waterFlowPerMinute);
                            if (squareMeters[i][j].IsOff())
                            {
                                remainingFireList.Add(0);
                            }
                            else
                            {
                                remainingFireList.Add(Math.Round(squareMeters[i][j].GetFireDamage(), 2));
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Difficulties in the sector:");
                        Console.ResetColor();
                        Console.WriteLine($" {squareMeters[i][j].ToString()} - SECTOR: ({i},{j}) -> " + string.Join(" -> ", remainingFireList));
                    }

                    goToRight = false;
                    goToLeft = true;
                    continue;
                }

                if (goToLeft)
                {
                    for (int j = squareMeters[i].Length - 1; j >= 0; j--)
                    {
                        var remainingFireList = new List<double>();
                        remainingFireList.Add(squareMeters[i][j].GetFireDamage());

                        while (!squareMeters[i][j].IsOff())
                        {
                            squareMeters[i][j].Wet(waterFlowPerMinute);
                            if (squareMeters[i][j].IsOff())
                            {
                                remainingFireList.Add(0);
                            }
                            else
                            {
                                remainingFireList.Add(Math.Round(squareMeters[i][j].GetFireDamage(), 2));
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Difficulties in the sector:");
                        Console.ResetColor();
                        Console.WriteLine($" {squareMeters[i][j].ToString()} - SECTOR: ({i},{j}) -> " + string.Join(" -> ", remainingFireList));
                    }

                    goToRight = true;
                    goToLeft = false;
                    continue;
                }
            }
        }
    }
}
