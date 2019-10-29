using System;
using Application.Heroes;
using Domain.Enums;
using Domain.Fire;
using Heroes.Domain.Compliants;
using Heroes.Domain.FactoryHeroes;

namespace Heroes.Domain.Fireman.FiremanProxy
{
    public class FiremanProxy : IResponsable
    {
        public FireFighterFactory _fireFighterFactory = null;

        public Firefighter CreateHeroe(CompliantHandler handler)
        {
            if (_fireFighterFactory == null)
            {
                _fireFighterFactory = new FireFighterFactory();
            }

            var fireman = (Firefighter)_fireFighterFactory.CreateHeroe(handler);
            fireman.Tool = _fireFighterFactory.CreateTool();
            fireman.Vehicle = _fireFighterFactory.CreateVehicle();

            DisplayStrategy();

            var success = Int32.TryParse(Console.ReadLine(), out int strategySelect);
            while (!success || strategySelect >= 3)
            {
                Console.Clear();
                Console.WriteLine("Wrong option! :( Please try again.");
                DisplayStrategy();
                success = Int32.TryParse(Console.ReadLine(), out strategySelect);
            }

            var strategy = (FireFighterStrategyEnum)strategySelect;
            switch (strategy)
            {
                case FireFighterStrategyEnum.Sequential:
                    fireman.ChangeExtinguishStrategy(new SequentialStrategy());
                    break;
                case FireFighterStrategyEnum.StairCase:
                    fireman.ChangeExtinguishStrategy(new StaircaseStrategy());
                    break;
                case FireFighterStrategyEnum.Spiral:
                    fireman.ChangeExtinguishStrategy(new SpiralStrategy());
                    break;
                default:
                    break;
            }

            return fireman;
        }

        private void DisplayStrategy()
        {
            var enumList = Enum.GetValues(typeof(FireFighterStrategyEnum));
            for (int i = 0; i < enumList.Length; i++)
            {
                Console.WriteLine(String.Format("{0}) {1}", i, enumList.GetValue(i)));
            }
            Console.Write("Select firefighter strategy:");
        }
    }
}
