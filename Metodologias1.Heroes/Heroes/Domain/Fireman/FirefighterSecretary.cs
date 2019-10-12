using Application.Heroes;

namespace Heroes.Domain.Fireman
{
    public class FirefighterSecretary
    {
        public Firefighter Firefighter { get; set; }

        public FirefighterSecretary(Firefighter firefighter)
        {
            Firefighter = firefighter;
        }

        public void AttendCompliant(IComplaints compliants)
        {
            var iterator = new CompliantIterator(compliants);
            iterator.First();

            while (!iterator.IsEnd())
            {
                iterator.Current().Attend(this.Firefighter);
                iterator.MoveNext();
            }
        }
    }
}
