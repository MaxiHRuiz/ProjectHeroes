using Heroes.Heroes;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cop = new Policeman();
            cop.ArrestCriminal();
            cop.PatrolStreet();
        }
    }
}
