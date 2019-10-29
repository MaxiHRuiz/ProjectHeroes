using Heroes.Domain.Fireman;

namespace Heroes.Domain.Compliants
{
    public class Operator911
    {
        public IResponsable Responsable { get; set; }

        public Operator911(IResponsable heroe)
        {
            this.Responsable = heroe;
        }

        public void AttendReport(IComplaints complaints)
        {
            var iterator = complaints.GetIterator();
            iterator.First();

            while (!iterator.IsEnd())
            {
                var compliant = iterator.Current();
                compliant.Attend(Responsable);
                iterator.MoveNext();
            }
        }
    }
}
