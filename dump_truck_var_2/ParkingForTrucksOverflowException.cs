using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump_truck_var_2
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже заняты все места"
    /// </summary>
    class ParkingForTrucksOverflowException : Exception
    {
        public ParkingForTrucksOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
