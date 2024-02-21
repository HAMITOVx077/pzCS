using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz19
{
    public class Ferryboat : PublicTransport
    {
        public Ferryboat(string transportName) : base(transportName, 50, 100) { }
        public override void Passengers()
        {
            Console.WriteLine($"Паром {transportName} перевозит пассажиров. Вместимость транспорта {capacity} человек, стоимость проезда {fare} рублей");
        }
    }
}
