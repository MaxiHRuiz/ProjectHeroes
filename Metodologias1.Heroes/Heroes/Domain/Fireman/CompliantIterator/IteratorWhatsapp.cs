using Heroes.Domain.Compliants;

namespace Heroes.Domain.Fireman.CompliantIterator
{
    public class IteratorWhatsapp : ICompliantIterator
    {
        public WhatsAppMessage Compliant { get; set; }

        public IteratorWhatsapp(WhatsAppMessage complaint)
        {
            this.Compliant = complaint;
        }

        public IComplaint Current()
        {
            return this.Compliant;
        }

        public void First() { }

        public bool IsEnd()
        {
            return this.Compliant == null;
        }

        public void MoveNext()
        {
            this.Compliant = this.Compliant.NextMessage;
        }
    }
}