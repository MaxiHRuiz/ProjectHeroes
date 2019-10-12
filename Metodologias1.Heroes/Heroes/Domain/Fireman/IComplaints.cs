using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Fireman
{
    public interface IComplaints
    {
        List<IComplaint> ComplaintList { get; set; }
    }
}
