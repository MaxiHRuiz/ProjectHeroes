using System.Collections.Generic;
using Domain.Place;
using Heroes.Domain.Compliants;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByDesk : IComplaints
    {
        public List<IComplaint> ComplaintList { get; set; } = new List<IComplaint>();

        public ComplaintByDesk(IPlace place)
        {
            var report = new FireReport(place);
            this.ComplaintList.Add(report);
        }
    }
}