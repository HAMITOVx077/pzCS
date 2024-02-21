using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz19
{
    public class Bus : PublicTransport
    {
        public Bus(string transportName) : base(transportName, 20, 30) { }
        public override void Passengers()
        {
            Console.WriteLine($"Автобус {transportName} перевозит пассажиров. Вместимость транспорта {capacity} человек, стоимость проезда {fare} рублей");
        }
    }
}
