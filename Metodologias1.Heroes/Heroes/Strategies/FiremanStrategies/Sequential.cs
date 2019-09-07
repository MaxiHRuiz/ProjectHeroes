using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.Strategies.FiremanStrategies
{
    public class Sequential : IExtinguishFire
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
                    Console.Write("Difficulties in the sector:");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[i][j].ToString()} - SECTOR: ({i},{j}) -> " + string.Join(" -> ", remainingFireList));
                }
            }
        }
    }
}
