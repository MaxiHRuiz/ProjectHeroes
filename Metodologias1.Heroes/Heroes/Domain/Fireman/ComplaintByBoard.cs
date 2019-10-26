using System.Collections.Generic;
using Domain.Place;
using Heroes.Domain.Compliants;
using Heroes.Domain.Fireman.CompliantIterator;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByBoard : IComplaints, IFireObserver
    {
        public List<IComplaint> ComplaintList { get; set; } = new List<IComplaint>();
        public ICompliantIterator Iterator { get; set; }

        public ICompliantIterator GetIterator()
        {
            return new IteratorBoard(ComplaintList);
        }

        public void SoundAlarm(IPlace place)
        {
            var report = new FireReport(place);
            ComplaintList.Add(report);
        }
    }
}