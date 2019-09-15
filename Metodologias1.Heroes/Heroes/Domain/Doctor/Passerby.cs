using Domain.RandomValue;

namespace Heroes.Domain.Doctor
{
    public class Passerby : IHeartAttack
    {
        public int Probability { get; set; } = 5;

        public bool IsAware()
        {
            var response = GenerateRandomValue.GetRandom(11) > Probability ? true : false;
            return response;
        }

        public bool IsBreathing()
        {
            var response = GenerateRandomValue.GetRandom(11) > Probability ? true : false;
            return response;
        }

        public bool ItHasHeartRhythm()
        {
            var response = GenerateRandomValue.GetRandom(11) > Probability ? true : false;
            return response;
        }
    }
}