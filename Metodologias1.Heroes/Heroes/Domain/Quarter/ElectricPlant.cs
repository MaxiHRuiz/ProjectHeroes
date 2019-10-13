using System;
using System.Collections.Generic;
using System.Linq;
using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.Quarter
{
    public class ElectricPlant : IQuarter
    {
        public List<ITool> Tools { get; set; }

        public List<IVehicle> Vehicles { get; set; }

        public List<IResponsable> Electricians { get; set; }

        public ElectricPlant()
        {
            this.Tools = new List<ITool>();
            this.Vehicles = new List<IVehicle>();
            this.Electricians = new List<IResponsable>();
        }

        public void AddTool(ITool tool)
        {
            this.Tools.Add(tool);
        }

        public void AddResponsable(IResponsable heroe)
        {
            this.Electricians.Add(heroe);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public IResponsable GetPersonal()
        {
            var electrician = (Electrician)this.Electricians.Last();
            this.Electricians.Remove(this.Electricians.Last());

            electrician.Vehicle = this.Vehicles.Last();
            electrician.Tool = this.Tools.Last();

            this.Vehicles.Remove(this.Vehicles.Last());
            this.Tools.Remove(this.Tools.Last());

            return electrician;
        }
    }
}