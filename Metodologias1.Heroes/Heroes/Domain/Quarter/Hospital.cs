using System;
using System.Collections.Generic;
using System.Linq;
using Application.Heroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;

namespace Heroes.Domain.Quarter
{
    public class Hospital : IQuarter
    {
        private static Hospital hospital = null;

        public List<ITool> Tools { get; set; }

        public List<IVehicle> Vehicles { get; set; }

        public List<IResponsable> Medics { get; set; }

        private Hospital()
        {
            this.Tools = new List<ITool>();
            this.Vehicles = new List<IVehicle>();
            this.Medics = new List<IResponsable>();
        }

        public void AddTool(ITool tool)
        {
            this.Tools.Add(tool);
        }

        public void AddResponsable(IResponsable heroe)
        {
            this.Medics.Add(heroe);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public IResponsable GetPersonal()
        {
            var medic = (Application.Heroes.Medic)this.Medics.Last();
            this.Medics.Remove(this.Medics.Last());

            medic.Vehicle = this.Vehicles.Last();
            medic.Tool = this.Tools.Last();

            this.Vehicles.Remove(this.Vehicles.Last());
            this.Tools.Remove(this.Tools.Last());

            return medic;
        }

        public static Hospital GetInstance()
        {
            if (hospital == null)
            {
                hospital = new Hospital();
            }

            return hospital;
        }
    }
}