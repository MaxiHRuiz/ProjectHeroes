using System.Collections.Generic;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman.CompliantIterator;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByDesk : IComplaints
    {
        public IComplaint Complaint { get; set; }

        public ComplaintByDesk(IPlace place)
        {
            var report = new FireReport(place);
            this.Complaint = report;
        }

        public ICompliantIterator GetIterator()
        {
            return new IteratorDesk(Complaint);
        }
    }
}