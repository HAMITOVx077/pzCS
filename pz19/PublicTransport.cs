using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz19
{
    public class PublicTransport
    {
        public string transportName; //название транспорта
        public int capacity; //вместительность
        public double fare; //цена проезда

        public PublicTransport(string transportName, int capacity, double fare)
        {
            this.transportName = transportName;
            this.capacity = capacity;
            this.fare = fare;
        }
        public virtual void Passengers()
        {
            Console.WriteLine($"Транспорт {transportName} перевозит пассажиров. Вместительность транспорта {capacity} человек, стоимость проезда {fare} рублей");
        }
        public static bool operator ==(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity == transp2.capacity;
        }
        public static bool operator !=(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity != transp2.capacity;
        }
        public static bool operator >(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity > transp2.capacity;
        }
        public static bool operator <(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity < transp2.capacity;
        }
        public static bool operator >=(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity >= transp2.capacity;
        }
        public static bool operator <=(PublicTransport transp1, PublicTransport transp2)
        {
            return transp1.capacity <= transp2.capacity;
        }
    }
}
