using System;
using System.Collections.Generic;
using Domain.Place;

namespace Domain.Fire
{
    public class SpiralStrategy : IExtinguishFire
    {
        public void ExtinguishFire(ISector[][] squareMeters, int waterFlowPerMinute)
        {
            var fieldExtinguish = squareMeters.Length * squareMeters.Length;
            var x = 0;
            int y = 0;

            var top = 0;
            var left = 0;
            var right = squareMeters.Length - 1;
            var down = squareMeters.Length - 1;

            var goRight = true;
            var goUp = false;
            var goDown = false;
            var goLeft = false;

            while (fieldExtinguish > 0)
            {
                var remainingFireList = new List<double>();
                remainingFireList.Add(squareMeters[x][y].GetFireDamage());

                if (goRight)
                {
                    while (!squareMeters[x][y].IsOff())
                    {
                        squareMeters[x][y].Wet(waterFlowPerMinute);
                        if (squareMeters[x][y].IsOff())
                        {
                            remainingFireList.Add(0);
                        }
                        else
                        {
                            remainingFireList.Add(Math.Round(squareMeters[x][y].GetFireDamage(), 2));
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Difficulties in the sector({x},{y}):");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[x][y].ToString()} - START -> " + string.Join(" -> ", remainingFireList));
                    fieldExtinguish--;

                    if (x == top && y == right)
                    {
                        x++;
                        top++;
                        goDown = true;
                        goRight = false;
                    }
                    else
                    {
                        y++;
                    }
                }
                else if (goDown)
                {
                    while (!squareMeters[x][y].IsOff())
                    {
                        squareMeters[x][y].Wet(waterFlowPerMinute);
                        if (squareMeters[x][y].IsOff())
                        {
                            remainingFireList.Add(0);
                        }
                        else
                        {
                            remainingFireList.Add(Math.Round(squareMeters[x][y].GetFireDamage(), 2));
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Difficulties in the sector({x},{y}):");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[x][y].ToString()} - START -> " + string.Join(" -> ", remainingFireList));
                    fieldExtinguish--;

                    if (x == down && y == right)
                    {
                        y--;
                        right--;
                        goLeft = true;
                        goDown = false;
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (goLeft)
                {
                    while (!squareMeters[x][y].IsOff())
                    {
                        squareMeters[x][y].Wet(waterFlowPerMinute);
                        if (squareMeters[x][y].IsOff())
                        {
                            remainingFireList.Add(0);
                        }
                        else
                        {
                            remainingFireList.Add(Math.Round(squareMeters[x][y].GetFireDamage(), 2));
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Difficulties in the sector({x},{y}):");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[x][y].ToString()} - START -> " + string.Join(" -> ", remainingFireList));
                    fieldExtinguish--;

                    if (x == down && y == left)
                    {
                        x--;
                        down--;
                        goUp = true;
                        goLeft = false;
                    }
                    else
                    {
                        y--;
                    }
                }
                else if (goUp)
                {
                    while (!squareMeters[x][y].IsOff())
                    {
                        squareMeters[x][y].Wet(waterFlowPerMinute);
                        if (squareMeters[x][y].IsOff())
                        {
                            remainingFireList.Add(0);
                        }
                        else
                        {
                            remainingFireList.Add(Math.Round(squareMeters[x][y].GetFireDamage(), 2));
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Difficulties in the sector({x},{y}):");
                    Console.ResetColor();
                    Console.WriteLine($" {squareMeters[x][y].ToString()} - START -> " + string.Join(" -> ", remainingFireList));
                    fieldExtinguish--;

                    if (x == top)
                    {
                        y++;
                        left++;
                        goRight = true;
                        goUp = false;
                    }
                    else
                    {
                        x--;
                    }
                }
            }
        }

        public override string ToString()
        {
            return "Spiral";
        }
    }
}
