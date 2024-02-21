using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz19
{
    public class Trolleybus : PublicTransport
    {
        public Trolleybus(string transportName) : base(transportName, capacity: 30, fare: 20) { }
        public override void Passengers()
        {
            Console.WriteLine($"Троллейбус {transportName} перевозит пассажиров. Вместимость транспорта {capacity} человек, стоимость проезда {fare} рублей");
        }
    }
}
