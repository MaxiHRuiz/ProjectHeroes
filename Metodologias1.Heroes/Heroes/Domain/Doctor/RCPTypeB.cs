﻿using System;

namespace Heroes.Domain.Doctor
{
    public class RCPTypeB : RCP
    {
        public const int Retries = 5;

        protected override void CheckPatientStatus(IHeartAttack passerby)
        {
            if (!passerby.IsAware())
            {
                this.CallAmbulance();
                this.FindThorax();
                this.PositionHead();

                var attempts = 0;
                while (!passerby.IsBreathing() || attempts < Retries)
                {
                    this.ChestCompressions();
                    this.Insufflations();

                    if (passerby.ItHasHeartRhythm())
                    {
                        this.UseDefibrillator();
                    }

                    attempts++;
                }
                if (attempts.Equals(5))
                {
                    Console.WriteLine("Type B: The doctor gave up and the patient died :(");
                }
                else
                {
                    Console.WriteLine("The doctor has helped the patient. He seems fine now :)");
                }
            }
        }

        protected override void CallAmbulance()
        {
            Console.WriteLine("Type B: The doctor's calling the ambulance...");
        }

        protected override void ChestCompressions()
        {
            Console.WriteLine("Type B: The doctor's applying chest compressions...");
        }

        protected override void FindThorax()
        {
            Console.WriteLine("Type B: The doctor's checking the thorax...");
        }

        protected override void Insufflations()
        {
            Console.WriteLine("Type B: The doctor's performing insufflation...");
        }

        protected override void PositionHead()
        {
            Console.WriteLine("Type B: The doctor's repositioning the patient's head...");
        }

        protected override void RemoveObstructingAirwayObjects()
        {
            Console.WriteLine("Type B: The doctor's removing any kind of obstructing airway object from the patient...");
        }

        protected override void UseDefibrillator()
        {
            Console.WriteLine("Type B: The doctor's using the defibrillator...");
        }
    }
}