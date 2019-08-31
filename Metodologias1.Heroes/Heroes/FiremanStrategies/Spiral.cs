using System;
using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.FiremanStrategies
{
    public class Spiral : IExtinguishFire
    {
        public void ExtinguishFire(int[][] squareMeters, int waterFlowPerMinute)
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
                var fireLeft = new List<int>();
                fireLeft.Add(squareMeters[x][y]);

                if (goRight)
                {
                    while (squareMeters[x][y] > 0)
                    {
                        squareMeters[x][y] -= waterFlowPerMinute;
                        if (squareMeters[x][y] < 0)
                        {
                            fireLeft.Add(0);
                        }
                        else
                        {
                            fireLeft.Add(squareMeters[x][y]);
                        }
                    }

                    Console.WriteLine($"({x},{y}) -> " + string.Join(" -> ", fireLeft));
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
                    while (squareMeters[x][y] > 0)
                    {
                        squareMeters[x][y] -= waterFlowPerMinute;
                        if (squareMeters[x][y] < 0)
                        {
                            fireLeft.Add(0);
                        }
                        else
                        {
                            fireLeft.Add(squareMeters[x][y]);
                        }
                    }

                    Console.WriteLine($"({x},{y}) -> " + string.Join(" -> ", fireLeft));
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
                    while (squareMeters[x][y] > 0)
                    {
                        squareMeters[x][y] -= waterFlowPerMinute;
                        if (squareMeters[x][y] < 0)
                        {
                            fireLeft.Add(0);
                        }
                        else
                        {
                            fireLeft.Add(squareMeters[x][y]);
                        }
                    }

                    Console.WriteLine($"({x},{y}) -> " + string.Join(" -> ", fireLeft));
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
                    while (squareMeters[x][y] > 0)
                    {
                        squareMeters[x][y] -= waterFlowPerMinute;
                        if (squareMeters[x][y] < 0)
                        {
                            fireLeft.Add(0);
                        }
                        else
                        {
                            fireLeft.Add(squareMeters[x][y]);
                        }
                    }

                    Console.WriteLine($"({x},{y}) -> " + string.Join(" -> ", fireLeft));
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
    }
}
