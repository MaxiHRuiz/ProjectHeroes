using System.Collections.Generic;
using Heroes.Interfaces;

namespace Heroes.Composites
{
    public class CompositePlace : IIlluminate
    {
        private List<IIlluminate> Places { get; set; }

        public CompositePlace()
        {
            this.Places = new List<IIlluminate>();
        }

        public void CheckAndChangeBurntLamps()
        {
            foreach (var place in this.Places)
            {
                place.CheckAndChangeBurntLamps();
            }
        }

        public void AddPlace(IIlluminate place)
        {
            this.Places.Add(place);
        }

        public void RemovePlace(IIlluminate place)
        {
            this.Places.Remove(place);
        }
    }
}
