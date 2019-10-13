using Heroes.Domain.Compliants;

namespace Heroes.Domain.Fireman
{
    public class WhatsAppMessage: IComplaint
    {
        public IComplaint Compliant { get; set; }

        public WhatsAppMessage NextMessage { get; set; }

        public WhatsAppMessage(IComplaint fireReport, WhatsAppMessage message)
        {
            Compliant = fireReport;
            NextMessage = message;
        }

        public void Attend(IResponsable responsable)
        {
            Compliant.Attend(responsable);
            NextMessage?.Attend(responsable);
        }
    }
}