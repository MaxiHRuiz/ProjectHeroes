using System;
using Domain.Place;
using Domain.RandomValue;
using Heroes.Domain.Police;

namespace Application.Places
{
    public class StreetCorner: IIlluminate, IPatrol
    {
        public int Semaphores { get; set; }

        public StreetCorner(int numberSemaphores)
        {
            this.Semaphores = numberSemaphores;
        }

        public void CheckAndChangeBurntLamps()
        {
            Console.WriteLine($"The corner has {this.Semaphores} semaphores to check...");
        }

        public bool ThereIsSomethingOutOfOrdinary()
        {
            return GenerateRandomValue.GetRandom(101) >= 30 ? true : false;
        }
    }
}