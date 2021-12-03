using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump_truck_var_2
{
    class ParkingForTrucksNotFoundException : Exception
    {
        public ParkingForTrucksNotFoundException(int i) : base("Не найден автомобиль по месту "+ i)
        { }
    }
}
