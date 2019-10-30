using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes.Domain.Quarter.Vehicle.State
{
    public class TurnedOn : Engine
    {
        public TurnedOn(IVehicle vehicle) : base(vehicle)
        {
        }

        public override void Accelerate()
        {
            this.Vehicle.SetState(new TurnedOn(Vehicle));
        }
    }
}
