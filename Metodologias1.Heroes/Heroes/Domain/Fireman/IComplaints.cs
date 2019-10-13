using System.Collections.Generic;

namespace Heroes.Domain.Fireman
{
    public interface IComplaints
    {
        List<IComplaint> ComplaintList { get; set; }
    }
}
