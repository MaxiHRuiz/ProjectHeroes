using System;
using Application.Heroes;
using Domain.Enums;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.FactoryHeroes;
using Heroes.Domain.Fireman;

namespace Heroes.Domain.HeroesProxy
{
    public class MedicProxy : IResponsable
    {
        public MedicFactory _medicFactory = null;

        public Medic CreateHeroe(CompliantHandler handler = null)
        {
            if (_medicFactory == null)
            {
                _medicFactory = new MedicFactory();
            }

            var doctor = (Medic)_medicFactory.CreateHeroe(handler);
            doctor.Tool = _medicFactory.CreateTool();
            doctor.Vehicle = _medicFactory.CreateVehicle();

            DisplayCommand();
            var success = Int32.TryParse(Console.ReadLine(), out int rcpSelected);

            while (!success || rcpSelected >= 2)
            {
                Console.Clear();
                Console.WriteLine("Wrong option! :( Please try again.");
                DisplayCommand();
                success = Int32.TryParse(Console.ReadLine(), out rcpSelected);
            }

            var strategy = (RcpEnum)rcpSelected;
            switch (strategy)
            {
                case RcpEnum.RcpTypeA:
                    doctor.Rcp = new RCPTypeA();
                    break;
                case RcpEnum.RcpTypeB:
                    doctor.Rcp = new RCPTypeB();
                    break;
                default:
                    break;
            }

            return doctor;
        }

        private void DisplayCommand()
        {
            var enumList = Enum.GetValues(typeof(RcpEnum));
            for (int i = 0; i < enumList.Length; i++)
            {
                Console.WriteLine(String.Format("{0}) {1}", i, enumList.GetValue(i)));
            }
            Console.Write("Select RCP type:");
        }
    }
}
