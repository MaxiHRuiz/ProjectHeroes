using System;
using System.Collections.Generic;
using System.Linq;
using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.Quarter
{
    public class PoliceStation : IQuarter
    {
        public List<ITool> Tools { get; set; }

        public List<IVehicle> Vehicles { get; set; }

        public List<IResponsable> Cops { get; set; }

        public PoliceStation()
        {
            this.Tools = new List<ITool>();
            this.Vehicles = new List<IVehicle>();
            this.Cops = new List<IResponsable>();
        }

        public void AddTool(ITool tool)
        {
            this.Tools.Add(tool);
        }

        public void AddResponsable(IResponsable heroe)
        {
            this.Cops.Add(heroe);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public IResponsable GetPersonal()
        {
            var cop = (Cop)this.Cops.Last();
            this.Cops.Remove(this.Cops.Last());

            cop.Vehicle = this.Vehicles.Last();
            cop.Tool = this.Tools.Last();

            this.Vehicles.Remove(this.Vehicles.Last());
            this.Tools.Remove(this.Tools.Last());

            return cop;
        }
    }
}