namespace pz19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trolleybus trol1 = new Trolleybus("Троллейбус-1");
            Bus bus1 = new Bus("Автобус-1");
            Ferryboat fer1 = new Ferryboat("Паром-1");

            Trolleybus trol2 = new Trolleybus("Троллейбус-2");
            Bus bus2 = new Bus("Автобус-2");
            Ferryboat fer2 = new Ferryboat("Паром-2");

            trol1.Passengers();
            bus1.Passengers();
            fer1.Passengers();

            trol2.Passengers();
            bus2.Passengers();
            fer2.Passengers();

            Console.WriteLine($"Вместимость троллейбуса-1 равна вместимости автобуса-1: {trol1 == bus1}");
            Console.WriteLine($"Вместимость троллейбуса-2 больше вместимости парома-1: {trol2 > fer1}");
            Console.WriteLine($"Вместимость автобуса-1 меньше вместимости автобуса-2: {bus1 < bus2}");
            Console.WriteLine($"Вместимость парома-2 не равна вместимости троллейбуса-2: {fer2 != trol2}");
        }
    }
}
