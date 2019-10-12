using System.Collections.Generic;
using Domain.Place;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByBoard : IComplaints, IFireObserver
    {
        public List<IComplaint> ComplaintList { get; set; } = new List<IComplaint>();

        public void SoundAlarm(IPlace place)
        {
            var report = new FireReport(place);
            ComplaintList.Add(report);
        }
    }
}