using System.Collections.Generic;
using System.Linq;
using Heroes.Domain.Compliants;

namespace Heroes.Domain.Fireman.CompliantIterator
{
    public class IteratorBoard : ICompliantIterator
    {
        public int CurrentCompliant { get; set; }
        public List<IComplaint> CompliantList { get; set; }

        public IteratorBoard(List<IComplaint> complaints)
        {
            this.CurrentCompliant = 0;
            this.CompliantList = complaints;
        }

        public void First()
        {
            this.CurrentCompliant = 0;
        }

        public void MoveNext()
        {
            this.CurrentCompliant++;
        }

        public bool IsEnd()
        {
            return CurrentCompliant == this.CompliantList.Count();
        }

        public IComplaint Current()
        {
            return this.CompliantList[CurrentCompliant];
        }
    }
}