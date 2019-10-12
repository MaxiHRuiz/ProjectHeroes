using System;
using Application.Heroes;
using Heroes.Domain.Doctor;
using Heroes.Domain.Fireman;
using Heroes.Domain.Police;

namespace Heroes.Domain.Compliants
{
    public class RobberyReport : IComplaint
    {
        public IPatrol Place { get; set; }

        public void Attend(IResponsable responsable)
        {
            var handler = (CompliantHandler)responsable;
            handler.PatrolStreet(Place);
            Console.WriteLine();
            //var police = (Cop)responsable;
            //police.PatrolStreet(Place);
        }
    }
}