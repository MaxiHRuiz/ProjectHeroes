using System.Collections.Generic;
using System.Linq;

namespace Heroes.Domain.Fireman
{
    public class CompliantIterator
    {
        public int CurrentCompliant { get; set; }
        public List<IComplaint> CompliantList { get; set; }

        public CompliantIterator(IComplaints compliants)
        {
            this.CurrentCompliant = 0;
            this.CompliantList = compliants.ComplaintList;
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
