using Heroes.Domain.Fireman.CompliantIterator;

namespace Heroes.Domain.Fireman
{
    public interface IComplaints
    {
        ICompliantIterator GetIterator();
    }
}