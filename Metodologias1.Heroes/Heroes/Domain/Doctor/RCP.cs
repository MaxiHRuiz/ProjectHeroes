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

        protected virtual void CheckPatientStatus(IHeartAttack passerby)
        {
            if (!passerby.IsAware())
            {
                this.CallAmbulance();
                this.FindThorax();
                this.PositionHead();

                while (!passerby.IsBreathing())
                {
                    this.ChestCompressions();
                    this.Insufflations();

                    if (passerby.ItHasHeartRhythm())
                    {
                        this.UseDefibrillator();
                    }
                }
            }

            Console.WriteLine("The doctor has helped the patient. He seems fine now :)");
        }

        protected abstract void RemoveObstructingAirwayObjects();
        protected abstract void CallAmbulance();
        protected abstract void FindThorax();
        protected abstract void PositionHead();
        protected abstract void ChestCompressions();
        protected abstract void Insufflations();
        protected abstract void UseDefibrillator();
    }
}
