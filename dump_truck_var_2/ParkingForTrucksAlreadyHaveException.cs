using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump_truck_var_2
{
    class ParkingForTrucksAlreadyHaveException : Exception
    {
        public ParkingForTrucksAlreadyHaveException() : base("На парковке уже есть такой грузовик") { }
    }
}
