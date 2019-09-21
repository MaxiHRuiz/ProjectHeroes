using System;

namespace Heroes.Domain.Doctor
{
    public abstract class RCP
    {
        public void AttendHeartAttack(IHeartAttack passerby)
        {
            this.RemoveObstructingAirwayObjects();

            this.CheckPatientStatus(passerby);
        }

        protected void CheckPatientStatus(IHeartAttack passerby)
        {
            var isBreathing = passerby.IsBreathing();
            if (!passerby.IsAware())
            {
                this.CallAmbulance();
                this.FindThorax();
                this.PositionHead();

                while (retry() && !isBreathing)
                {
                    this.ChestCompressions();
                    this.Insufflations();

                    if (passerby.ItHasHeartRhythm())
                    {
                        this.UseDefibrillator();
                    }

                    isBreathing = passerby.IsBreathing();
                }

                if (isBreathing)
                {
                    Console.WriteLine("The doctor has helped the patient. He seems fine now :)");
                }
                else
                {
                    Console.WriteLine("Type B: The doctor gave up and the patient died :(");
                }
            }
        }

        protected abstract void RemoveObstructingAirwayObjects();
        protected abstract void CallAmbulance();
        protected abstract void FindThorax();
        protected abstract void PositionHead();
        protected abstract void ChestCompressions();
        protected abstract void Insufflations();
        protected abstract void UseDefibrillator();
        protected abstract bool retry();
    }
}
