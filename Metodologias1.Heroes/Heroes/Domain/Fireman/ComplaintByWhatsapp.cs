using System.Collections.Generic;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByWhatsapp : IComplaints
    {
        public List<IComplaint> ComplaintList { get; set; } = new List<IComplaint>();

        public ComplaintByWhatsapp(WhatsAppMessage complaintList)
        {
            ComplaintList.Add(complaintList);
        }
    }
}