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
        private static PoliceStation policeStation = null;

        public List<ITool> Tools { get; set; }

        public List<IVehicle> Vehicles { get; set; }

        public List<IResponsable> Cops { get; set; }

        private PoliceStation()
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
            var cop = (Cop)policeStation.Cops.Last();
            policeStation.Cops.Remove(this.Cops.Last());

            cop.Vehicle = policeStation.Vehicles.Last();
            cop.Tool = policeStation.Tools.Last();

            this.Vehicles.Remove(policeStation.Vehicles.Last());
            this.Tools.Remove(policeStation.Tools.Last());

            return cop;
        }

        public static PoliceStation GetInstance()
        {
            if (policeStation == null)
            {
                policeStation = new PoliceStation();
            }

            return policeStation;
        }
    }
}