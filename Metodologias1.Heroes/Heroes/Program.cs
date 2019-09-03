using Heroes.Composites;
using Heroes.Heroes;
using Heroes.Places;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite();
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

        static void Composite()
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
            var corner9 = new StreetCorner(5);
            var corner10 = new StreetCorner(1);

            // Streets
            var street1 = new Street(110, 10, 25);
            var street2 = new Street(100, 12, 20);
            var street3 = new Street(80, 5, 10);
            var street4 = new Street(90, 8, 30);
            var street5 = new Street(70, 2, 15);
            var street6 = new Street(115, 3, 35);
            var street7 = new Street(105, 2, 30);
            var street8 = new Street(105, 4, 20);
            var street9 = new Street(85, 4, 15);

            // Squares
            var square1 = new Square("San Martin", 36, 5, 4);
            var square2 = new Square("Italia", 36, 5, 4);
            var square3 = new Square("Lezama", 36, 5, 4);
            var square4 = new Square("Plaza de Mayo", 60, 45, 20);


            // NeighborhoodA: 9 blocks, 2 square

            // Blocks
            var block1 = new CompositePlace();
            block1.Places.Add(street1);
            block1.Places.Add(street5);
            block1.Places.Add(corner1);

            var block2 = new CompositePlace();
            block1.Places.Add(street1);
            block1.Places.Add(street5);
            block1.Places.Add(street6);
            block1.Places.Add(corner1);
            block1.Places.Add(corner2);

            var block3 = new CompositePlace();
            block3.Places.Add(street1);
            block3.Places.Add(street6);
            block3.Places.Add(street7);
            block3.Places.Add(corner2);
            block3.Places.Add(corner3);
            block3.Places.Add(square1);

            var block4 = new CompositePlace();
            block4.Places.Add(street1);
            block4.Places.Add(street2);
            block4.Places.Add(street5);
            block4.Places.Add(corner1);
            block4.Places.Add(corner6);

            var block5 = new CompositePlace();
            block5.Places.Add(street1);
            block5.Places.Add(street2);
            block5.Places.Add(street5);
            block5.Places.Add(street6);
            block5.Places.Add(corner1);
            block5.Places.Add(corner6);
            block5.Places.Add(corner2);
            block5.Places.Add(corner7);

            var block6 = new CompositePlace();
            block6.Places.Add(street1);
            block6.Places.Add(street2);
            block6.Places.Add(street6);
            block6.Places.Add(street7);
            block6.Places.Add(corner2);
            block6.Places.Add(corner3);
            block6.Places.Add(corner7);
            block6.Places.Add(corner8);
            block6.Places.Add(square2);

            var neighborhoodA = new CompositePlace();
            neighborhoodA.Places.Add(block1);
            neighborhoodA.Places.Add(block2);
            neighborhoodA.Places.Add(block3);

            // NeighborhoodB: 7 blocks, 1 square

            // Blocks
            block1 = new CompositePlace();
            block1.Places.Add(street1);
            block1.Places.Add(street8);
            block1.Places.Add(corner4);

            block2 = new CompositePlace();
            block1.Places.Add(street1);
            block1.Places.Add(street8);
            block1.Places.Add(street9);
            block1.Places.Add(corner4);
            block1.Places.Add(corner5);

            block3 = new CompositePlace();
            block3.Places.Add(street1);
            block3.Places.Add(street2);
            block3.Places.Add(street8);
            block3.Places.Add(corner4);
            block3.Places.Add(corner9);
            block3.Places.Add(square3);

            block4 = new CompositePlace();
            block4.Places.Add(street1);
            block4.Places.Add(street2);
            block4.Places.Add(street8);
            block4.Places.Add(street9);
            block4.Places.Add(corner4);
            block4.Places.Add(corner5);
            block4.Places.Add(corner9);
            block4.Places.Add(corner10);
            block4.Places.Add(square4);

            var neighborhoodB = new CompositePlace();
            neighborhoodA.Places.Add(block1);
            neighborhoodA.Places.Add(block2);
            neighborhoodA.Places.Add(block3);
            neighborhoodA.Places.Add(block4);

            // NeighborhoodC: 5 blocks, 2 square
            var neighborhoodC = new CompositePlace();

            // NeighborhoodD: 6 blocks
            var neighborhoodD = new CompositePlace();

            var city = new CompositePlace();
            city.Places.Add(neighborhoodA);
            city.Places.Add(neighborhoodB);
            #endregion mocks

            elictrician.Checking(city);
        }
    }
}