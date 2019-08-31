using Heroes.FiremanStrategies;
using Heroes.Heroes;
using Heroes.Places;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var fireman = new Firefighter();

            var house1 = new House(100, 25, 4);
            var house2 = new House(102, 16, 1);
            var house3 = new House(104, 34, 5);
            var house4 = new House(106, 20, 3);
            var house5 = new House(108, 9, 2);
            var square = new Square("San Martin", 36, 5, 4);
            var street = new Street(110, 64, 25);

            house1.Street = street;
            house1.AddObserver(fireman);
            house2.Street = street;
            house2.AddObserver(fireman);
            house3.Street = street;
            house3.AddObserver(fireman);
            house4.Street = street;
            house4.AddObserver(fireman);
            house5.Street = street;
            house5.AddObserver(fireman);
            square.Street = street;
            square.AddObserver(fireman);

            house5.Spark();
            square.Spark();
        }
    }
}