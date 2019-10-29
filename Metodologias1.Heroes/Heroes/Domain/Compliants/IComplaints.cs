using Heroes.Domain.Fireman.CompliantIterator;

namespace Heroes.Domain.Compliants
{
    public interface IComplaints
    {
        ICompliantIterator GetIterator();
    }
}