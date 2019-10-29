using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public interface IComplaint
    {
        void Attend(IResponsable responsable);
    }
}