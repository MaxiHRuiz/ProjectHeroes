namespace Heroes.Domain.Fireman.CompliantIterator
{
    public class IteratorDesk : ICompliantIterator
    {
        public int CurrentCompliant { get; set; }
        public IComplaint Compliant { get; set; }
       
        public IteratorDesk(IComplaint Compliant)
        {
            this.Compliant = Compliant;
        }

        public void First()
        {
            this.CurrentCompliant = 0;
        }

        public void MoveNext()
        {
            this.CurrentCompliant++;
        }

        public bool IsEnd()
        {
            return CurrentCompliant > 0;
        }

        public IComplaint Current()
        {
            return this.Compliant;
        }
    }
}