using System;

namespace Heroes.Domain.Doctor
{
    public class RCPTypeA : RCP
    {
        protected override void CallAmbulance()
        {
            Console.WriteLine("RCP Type A: The doctor's calling the ambulance...");
        }

        protected override void ChestCompressions()
        {
            Console.WriteLine("RCP Type A: The doctor's applying chest compressions...");
        }

        protected override void FindThorax()
        {
            Console.WriteLine("RCP Type A: The doctor's checking the thorax...");
        }

        protected override void Insufflations()
        {
            Console.WriteLine("RCP Type A: The doctor's performing insufflation...");
        }

        protected override void PositionHead()
        {
            Console.WriteLine("RCP Type A: The doctor's repositioning the patient's head...");
        }

        protected override void RemoveObstructingAirwayObjects()
        {
            Console.WriteLine("RCP Type A: The doctor's removing any kind of obstructing airway object from the patient...");
        }

        protected override bool retry()
        {
            return true;
        }

        protected override void UseDefibrillator()
        {
            Console.WriteLine("RCP Type A: The doctor's is using the defibrillator...");
        }
    }
}
