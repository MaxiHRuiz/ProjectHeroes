using Domain.Place;

namespace Heroes.Domain.Fireman
{
    public interface IComplaint
    {
        void Attend(IResponsable responsable);
    }
}