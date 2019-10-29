using System;
using Application.Heroes;
using Domain.Enums;
using Heroes.Domain.Compliants;
using Heroes.Domain.FactoryHeroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Police;

namespace Heroes.Domain.HeroesProxy
{
    public class CopProxy : IResponsable
    {
        public CopFactory _copFactory = null;

        public Cop CreateHeroe(CompliantHandler handler = null)
        {
            if (_copFactory == null)
            {
                _copFactory = new CopFactory();
            }

            var cop = (Cop)_copFactory.CreateHeroe(handler);
            cop.Tool = _copFactory.CreateTool();
            cop.Vehicle = _copFactory.CreateVehicle();

            DisplayCommand();
            var success = Int32.TryParse(Console.ReadLine(), out int commandSelected);

            while (!success || commandSelected >= 3)
            {
                Console.Clear();
                Console.WriteLine("Wrong option! :( Please try again.");
                DisplayCommand();
                success = Int32.TryParse(Console.ReadLine(), out commandSelected);
            }

            var strategy = (CommandEnum)commandSelected;
            switch (strategy)
            {
                case CommandEnum.StopRightThere:
                    cop.ChangeOrder(new StopRightThere());
                    break;
                case CommandEnum.PursueCriminal:
                    cop.ChangeOrder(new PursueCriminal());
                    break;
                case CommandEnum.RequestBackup:
                    cop.ChangeOrder(new RequestBackup());
                    break;
                default:
                    break;
            }

            return cop;
        }

        private void DisplayCommand()
        {
            var enumList = Enum.GetValues(typeof(CommandEnum));
            for (int i = 0; i < enumList.Length; i++)
            {
                Console.WriteLine(String.Format("{0}) {1}", i, enumList.GetValue(i)));
            }
            Console.Write("Select police command:");
        }
    }
}
