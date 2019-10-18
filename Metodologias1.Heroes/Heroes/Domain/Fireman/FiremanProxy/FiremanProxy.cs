using System;
using Application.Heroes;
using Domain.Enums;
using Domain.Fire;
using Heroes.Domain.FactoryHeroes;

namespace Heroes.Domain.Fireman.FiremanProxy
{
    public class FiremanProxy : IResponsable
    {
        public FireFighterFactory _fireFighterFactory = null;

        public Firefighter CreateFirefighter()
        {
            if (_fireFighterFactory == null)
            {
                _fireFighterFactory = new FireFighterFactory();
            }

            var fireman = (Firefighter)_fireFighterFactory.CreateHeroe();
            fireman.Tool = _fireFighterFactory.CreateTool();
            fireman.Vehicle = _fireFighterFactory.CreateVehicle();

            var enumList = Enum.GetValues(typeof(FireFighterStrategyEnum));
            for (int i = 0; i < enumList.Length; i++)
            {
                Console.WriteLine(String.Format("{0}) {1}", i, enumList.GetValue(i)));
            }

            Console.Write("Select strategy:");
            var strategySelect = Convert.ToInt32(Console.ReadLine());
            while (strategySelect > 3)
            {
                Console.Clear();
                Console.Write("Select strategy:");
                strategySelect = Convert.ToInt32(Console.ReadLine());
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
    }
}
