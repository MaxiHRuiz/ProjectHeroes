using Heroes.Domain.Fireman.CompliantIterator;

namespace Heroes.Domain.Fireman
{
    public class ComplaintByWhatsapp : IComplaints
    {
        public WhatsAppMessage Complaint { get; set; }

        public ComplaintByWhatsapp(WhatsAppMessage complaintList)
        {
            Complaint = complaintList;
        }

        public ICompliantIterator GetIterator()
        {
            return new IteratorWhatsapp(Complaint);
        }
    }
}