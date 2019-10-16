using System;
using System.Collections.Generic;
using System.Linq;
using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.Quarter
{
    public class FireStation : IQuarter
    {
        private static FireStation fireStation = null;

        public List<ITool> Tools { get; set; }

        public List<IVehicle> Vehicles { get; set; }

        public List<IResponsable> FireFighters { get; set; }

        private FireStation()
        {
            this.Tools = new List<ITool>();
            this.Vehicles = new List<IVehicle>();
            this.FireFighters = new List<IResponsable>();
        }

        public void AddTool(ITool tool)
        {
            this.Tools.Add(tool);
        }

        public void AddResponsable(IResponsable heroe)
        {
            this.FireFighters.Add(heroe);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public IResponsable GetPersonal()
        {
            var fireFighter = (Firefighter)this.FireFighters.Last();
            this.FireFighters.Remove(this.FireFighters.Last());

            fireFighter.Vehicle = this.Vehicles.Last();
            fireFighter.Tool = this.Tools.Last();

            this.Vehicles.Remove(this.Vehicles.Last());
            this.Tools.Remove(this.Tools.Last());

            return fireFighter;
        }

        public static FireStation GetInstance()
        {
            if (fireStation == null)
            {
                fireStation = new FireStation();
            }

            return fireStation;
        }
    }
}