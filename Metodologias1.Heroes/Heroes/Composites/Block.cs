using Heroes.Places;

namespace Heroes.Composites
{
    public class Block
    {
        public StreetCorner[] Corners { get; set; } = new StreetCorner[4];

        public Street[] Streets { get; set; } = new Street[4];

        public Square Square { get; set; }
    }
}