using Heroes.FiremanStrategies;
using Heroes.Heroes;
using Heroes.Places;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House(5, 25, 10);
            var street = new Street(50, 2, 50);

            var fireman = new Firefighter();
            //fireman.PutOutFire(house, street);

            var square = new Square("test", 36, 5, 4);
            fireman.ChangeExtinguishStrategy(new Spiral());
            fireman.PutOutFire(square, street);

        }
    }
}