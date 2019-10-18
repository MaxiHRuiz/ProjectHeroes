using System;
using System.Collections.Generic;
using Domain.Place;

namespace Domain.Fire
{
    public class SequentialStrategy : IExtinguishFire
    {
        public void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute)
        {
            for (int i = 0; i < squareMeters.Length; i++)
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

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Difficulties in the sector({i},{j}):");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[i][j].ToString()} - START -> " + string.Join(" -> ", remainingFireList));
                }
            }
        }

        public override string ToString()
        {
            return "Sequential";
        }
    }
}
