using System.Collections.Generic;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class ComplaintList : IComplaints
    {
        List<IComplaint> IComplaints.ComplaintList { get; set; } = new List<IComplaint>();
    }
}
