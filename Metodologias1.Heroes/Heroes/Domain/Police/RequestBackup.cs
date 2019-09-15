using System;

namespace Heroes.Domain.Police
{
    public class RequestBackup : IPoliceOrder
    {
        public void Execute()
        {
            Console.WriteLine("The policeman is requesting support from the police station.");
        }
    }
}