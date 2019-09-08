using System;
using Domain.Place;

namespace Application.Places
{
    public class StreetCorner: IIlluminate
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
    }
}