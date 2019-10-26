namespace Heroes.Domain.Fireman.CompliantIterator
{
    public interface ICompliantIterator
    {
        void First();
        void MoveNext();
        bool IsEnd();
        IComplaint Current();
    }
}