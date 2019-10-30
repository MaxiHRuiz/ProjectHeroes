using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    public class TurnedOff : Engine
    {
        public TurnedOff(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void TurnOn()
        {
            this.Vehicle.SetState(new TurnedOn(Vehicle));
        }
    }
}
