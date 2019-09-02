using Heroes.Composites;
using Heroes.Heroes;
using Heroes.Places;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var elictrician = new Electrician();

            #region mocks
            // StreetCorners
            var corner1 = new StreetCorner(1);
            var corner2 = new StreetCorner(4);
            var corner3 = new StreetCorner(2);
            var corner4 = new StreetCorner(3);
            var corner5 = new StreetCorner(2);
            var corner6 = new StreetCorner(1);
            var corner7 = new StreetCorner(3);
            var corner8 = new StreetCorner(3);

            // Streets
            var street1 = new Street(110, 10, 25);
            var street2 = new Street(100, 12, 20);
            var street3 = new Street(80, 5, 10);
            var street4 = new Street(90, 8, 30);
            var street5 = new Street(70, 2, 15);
            var street7 = new Street(115, 3, 35);
            var street8 = new Street(105, 4, 20);
            var street9 = new Street(85, 4, 15);

            // Squares
            var square1 = new Square("San Martin", 36, 5, 4);
            var square2 = new Square("Italia", 36, 5, 4);
            var square3 = new Square("Lezama", 36, 5, 4);

            // Blocks
            var block1 = new Block();
            var block2 = new Block();
            var block3 = new Block();
            var block4 = new Block();
            var block5 = new Block();
            var block6 = new Block();

            // Neighborhoods
            // NeighborhoodA: 9 blocks, 2 square
            var neighborhoodA = new Neighborhood();

            // NeighborhoodB: 7 blocks, 1 square
            var neighborhoodB = new Neighborhood();

            // NeighborhoodC: 5 blocks, 2 square
            var neighborhoodC = new Neighborhood();

            // NeighborhoodD: 6 blocks
            var neighborhoodD = new Neighborhood();
            #endregion mocks

            elictrician.changeBurntLamps(square2);
        }

        static void Observer()
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